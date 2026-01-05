using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEditor.ProjectWindowCallback;
using System;
using System.Linq;
using System.Reflection;
using Object = UnityEngine.Object;
using Unity.VisualScripting;

public class LessonEditorWindow : EditorWindow
{
    private List<LessonStep> lessonStack = new List<LessonStep>();
    private LessonSO lessonSO;
    private LessonEditor lessonEditor;
    public ScriptableObject currentLessonObject;
    public List<LessonStep> currentSteps;
    // public LessonStep selectedStep;
    // public int selectedIndex = -1;
    private bool stackSelectedStep = false;
    private Editor stepEditor;
    private ScriptableObject selectedLibrary;
    private Editor libraryEditor;
   // private GroupStepEditorView groupStepEditorView;
    private LessonStep selectedSubStep;
    private Vector2 scroll;
    public LessonGraph lessonNodeGraph;
    bool showTimeline = true;
    bool showNodeGraph = false;
    private LessonPointerView pointerView;
    private LessonOutlinerView outlinerView;
    private LessonTimelineView timelineView;
    private LessonListDragAndDrop dragAndDrop;
    private LibraryOutlinerView libraryOutliner;
    private float dragDropSectionHeight = 200f;

    private bool isLibraryPage = false;
    // --- Grouping UI state ---
    public bool showGroupingPanel = false;

    public enum GroupTarget
    {
        Parallel,
        Loop,
        Sequential
    }
    public GroupTarget groupAs = GroupTarget.Parallel;

    // Which existing steps are selected for grouping
    public Dictionary<LessonStep, bool> groupSelection = new Dictionary<LessonStep, bool>();
    private bool showCreateNewStepMenu = false;
    private string newStepName = "";
    private string newFolderName = "";
    public StepLibrary StepLibrary;

    private GenericMenu menu;
    private GroupStepMenu _groupMenu;
    private CreateNewStepMenu _createNewStepMenu;


    [MenuItem("Lesson Tools/Lesson Editor")]

    public static void ShowWindow()
    {
        LessonEditorWindow window = GetWindow<LessonEditorWindow>("Lesson Editor");
        window.minSize = new Vector2(500, 350);
        LibraryEditorWindow window2 = GetWindow<LibraryEditorWindow>("Library Editor", typeof(LessonEditorWindow));
        window2.minSize = new Vector2(500, 350);

        window.Focus();
    }
    private void OnEnable()
    {
        StepLibrary = AssetDatabase.LoadAssetAtPath<StepLibrary>("Assets/SelfLearning/Assets/StepLibrary.asset");
        lessonEditor = new LessonEditor();


        outlinerView = new LessonOutlinerView(
            step => SelectStep(step),
            index => RemoveStepRecursive(index)
        );

        timelineView = new LessonTimelineView(
            (step, index) => SelectStep(step, index),
            index => RemoveStepRecursive(index)
        );

        dragAndDrop = new LessonListDragAndDrop(
            (step, index) => SelectStep(step, index),
            index => RemoveStepRecursive(index)
        );

        libraryOutliner = new LibraryOutlinerView();

        // groupStepEditorView = new GroupStepEditorView(
        //     subStep => SelectSubStep(subStep),
        //     () => { EditorUtility.SetDirty(lessonEditor.selectedStep); EditorUtility.SetDirty(lessonSO); }
        // );

        pointerView = new LessonPointerView(
            step => SelectStep(step),
            index => RemoveStepRecursive(index),
            step => SelectTab(step)
        );
        LessonRoot root = ScriptableObject.CreateInstance<LessonRoot>();
        root.Description = "Lesson Root";
        lessonStack.Add(root);

        if (StepLibrary != null)
        {
            StepLibrary.RefreshStepLibrary();
            EditorUtility.SetDirty(StepLibrary);
        }
        _groupMenu = new GroupStepMenu(this);
        _createNewStepMenu = new CreateNewStepMenu(this);
        menu = new GenericMenu();

        for (int i = 0; i < StepLibrary.stepLibraries.Count; i++)
        {
            string category = StepLibrary.stepLibraries[i][0];
            string stepName = StepLibrary.stepLibraries[i][1];
            string scriptName = StepLibrary.stepLibraries[i][2];
            string description = StepLibrary.stepLibraries[i][3];

            var type = GetTypeByName(scriptName); // convert string -> Type
            if (type == null)
            {
                menu.AddDisabledItem(new GUIContent($"{category}/{stepName} (Missing: {scriptName})"));
                continue;
            }

            var typeLocal = type;       // capture for lambda
            var descLocal = description;

            menu.AddItem(new GUIContent($"{category}/{stepName}"), false,
                () => AddStepByType(typeLocal, descLocal));

        }

    }

    private void OnGUI()
    {
        if (stackSelectedStep)
        {
            lessonStack.Add(lessonEditor.selectedStep);
            lessonEditor.selectedStep = null;
            lessonEditor.selectedIndex = -1;
            stackSelectedStep = false;
        }

        if (lessonStack.Count > 1)
        {
            currentLessonObject = lessonStack[lessonStack.Count - 1];
            var stepsField = currentLessonObject?.GetType().GetField("steps");
            currentSteps = stepsField?.GetValue(currentLessonObject) as List<LessonStep>;
            if (currentSteps == null)
            {
                stepsField.SetValue(currentLessonObject, new List<LessonStep>());
                currentSteps = stepsField.GetValue(currentLessonObject) as List<LessonStep>;
            }
        }
        else
        {
            currentLessonObject = lessonSO;
            currentSteps = lessonSO != null ? lessonSO.steps : null;

        }
        // --- Paint window background for both modes ---
        if (Event.current.type == EventType.Repaint)
        {
            GUI.DrawTexture(
                new Rect(0, 0, position.width, position.height),
                LessonEditorStyles.WindowBGTex,
                ScaleMode.StretchToFill
            );
        }

        // --- DARK MODE BUTTON ---
        EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
        GUILayout.FlexibleSpace();
        string modeLabel = LessonEditorStyles.UserDarkMode ? "🌙" : "☀️";
        if (GUILayout.Button(modeLabel, EditorStyles.toolbarButton, GUILayout.Width(130)))
        {
            LessonEditorStyles.UserDarkMode = !LessonEditorStyles.UserDarkMode;
            LessonEditorStyles.MarkStylesDirty();
            Repaint();
        }
        EditorGUILayout.EndHorizontal();

        var prevBg = GUI.backgroundColor;
        GUI.backgroundColor = LessonEditorStyles.PanelBG;

        scroll = EditorGUILayout.BeginScrollView(scroll, GUILayout.ExpandHeight(true));

        // --- HEADER LABEL (uses custom style)
        GUILayout.Space(5);
        GUILayout.Label("Lesson Sequence Editor", LessonEditorStyles.HeaderLabel); // HEADER

        // --- LESSON SO DROPDOWN ---
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Lesson SO:", GUILayout.Width(80));

        // Find all LessonSO assets
        string[] lessonGuids = AssetDatabase.FindAssets("t:LessonSO");
        List<LessonSO> allLessons = new List<LessonSO>();
        List<string> lessonNames = new List<string> { "None", "Create New..." };

        foreach (string guid in lessonGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            LessonSO lesson = AssetDatabase.LoadAssetAtPath<LessonSO>(path);
            if (lesson != null)
            {
                allLessons.Add(lesson);
                lessonNames.Add(lesson.name);
            }
        }

        // Find current selection index
        int currentIndex = 0; // Default to "None"
        if (lessonSO != null)
        {
            for (int i = 0; i < allLessons.Count; i++)
            {
                if (allLessons[i] == lessonSO)
                {
                    currentIndex = i + 2; // +2 because of "None" and "Create New..." options
                    break;
                }
            }
        }

        // Show dropdown
        int newIndex = EditorGUILayout.Popup(currentIndex, lessonNames.ToArray());

        // Handle selection
        if (newIndex != currentIndex)
        {
            if (newIndex == 0) // "None"
            {
                lessonSO = null;
            }
            else if (newIndex == 1) // "Create New..."
            {
                CreateNewLessonSO();
            }
            else
            {
                lessonSO = allLessons[newIndex - 2];
            }
        }

        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Space();

        if (lessonSO == null)
        {
            // --- INFO BOX (uses warning color)
            var prevColor = GUI.color;
            GUI.color = LessonEditorStyles.Warning;
            EditorGUILayout.HelpBox("Assign a LessonSO asset to begin.", MessageType.Info);
            GUI.color = prevColor;

            lessonEditor.selectedStep = null;
            EditorGUILayout.EndScrollView();
            GUI.backgroundColor = prevBg;
            return;
        }
        // --- ACTION BUTTONS (accent color)
        var prevContentColor2 = GUI.contentColor;
        GUI.contentColor = LessonEditorStyles.Accent;




        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Add Step ▼", GUILayout.Width(120)))
        {
            ShowAddStepMenu();
        }
        if (GUILayout.Button("Group Steps ▼", GUILayout.Width(140)))
        {
            // Toggle panel and seed the selection map
            showGroupingPanel = !showGroupingPanel;
            if (showGroupingPanel)
            {
                groupSelection.Clear();
                if (currentSteps != null)
                {
                    foreach (var s in currentSteps)
                        if (s != null) groupSelection[s] = false; // default: nothing selected
                }
            }
        }

        if (GUILayout.Button("Create New Step ▼", GUILayout.Width(140)))
        {
            showCreateNewStepMenu = !showCreateNewStepMenu;

        }


        EditorGUILayout.EndHorizontal();
        GUI.contentColor = prevContentColor2;
        if (showCreateNewStepMenu)
        {
            EditorGUILayout.BeginVertical(LessonEditorStyles.StepBox);

            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Step Name:", GUILayout.Width(80));

            // Text field to type the step name
            newStepName = EditorGUILayout.TextField(newStepName);
            EditorGUILayout.EndHorizontal();

            // Enter button


            EditorGUILayout.BeginVertical();
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Folder Name:", GUILayout.Width(80));
            newFolderName = EditorGUILayout.TextField(newFolderName);
            if (GUILayout.Button("Enter", GUILayout.Width(80)))
            {
                _createNewStepMenu.CreateNewStep(newStepName, newFolderName);
                showCreateNewStepMenu = false; // close menu after confirming
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndVertical();



            EditorGUILayout.EndVertical();

        }


        if (showGroupingPanel)
        {
            _groupMenu.GroupStepmenu();
        }

    
    

        EditorGUILayout.Space();
        EditorGUILayout.BeginVertical();

        // TAB VIEW: Showing pointer to the current step list
        pointerView.Draw(lessonStack);
        EditorGUILayout.EndVertical();


        // --- DRAG AND DROP SECTION with resizable height
        EditorGUILayout.BeginVertical(LessonEditorStyles.StepBox, GUILayout.Height(dragDropSectionHeight));
        dragAndDrop.Draw(currentLessonObject, lessonEditor.selectedStep, position);
        EditorGUILayout.EndVertical();
        // --- STEP INSPECTOR PANEL
        if (lessonEditor.selectedStep != null)
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Selected Step Editor", LessonEditorStyles.SectionLabel); // SECTION LABEL

            EditorGUILayout.BeginVertical(LessonEditorStyles.StepBox); // STEP BOX
            // Show the selected step's inspector fields
            if (stepEditor == null)
                stepEditor = Editor.CreateEditor(lessonEditor.selectedStep);

            if (stepEditor != null)
            {
                stepEditor.OnInspectorGUI();
                if (GUI.changed)
                {
                    EditorUtility.SetDirty(lessonEditor.selectedStep);
                    EditorUtility.SetDirty(lessonSO);
                }
            }
            EditorGUILayout.EndVertical();
        }

        // --- OUTLINER VIEW (step list): Main step box
        EditorGUILayout.Space(); // STEP BOX
        outlinerView.Draw(currentLessonObject, lessonEditor.selectedStep);
        EditorGUILayout.Space();

        // --- LIBRARY DATABASE PANEL (always show when lesson is selected)

        // --- TIMELINE (uses TimelineBox style)
        EditorGUILayout.BeginVertical(LessonEditorStyles.TimelineBox); // TIMELINE BOX
        timelineView.Draw(currentLessonObject, lessonEditor.selectedStep, position);
        EditorGUILayout.EndVertical();

        // --- DRAG AND DROP (no box, but can use style if you want)


        EditorGUILayout.EndScrollView();
        GUI.backgroundColor = prevBg;
        
    }


    private void CreateNewLessonSO()
    {
        // Simple text input using SaveFilePanelInProject which acts as name input
        string path = EditorUtility.SaveFilePanelInProject(
            "Create New Lesson",
            "NewLesson",
            "asset",
            "Enter lesson name (without extension):",
            "Assets/SelfLearning/Assets"
        );

        if (string.IsNullOrEmpty(path)) return; // User cancelled

        // Create the LessonSO instance
        LessonSO newLesson = ScriptableObject.CreateInstance<LessonSO>();
        newLesson.name = System.IO.Path.GetFileNameWithoutExtension(path);

        // Create the asset file
        AssetDatabase.CreateAsset(newLesson, path);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        // Select the new lesson
        lessonSO = newLesson;

        // Ping it in the project window
        EditorGUIUtility.PingObject(newLesson);
    }

    private void AddStep(System.Type stepType, string defaultDescription)
    {
        if (stepType == null || !typeof(LessonStep).IsAssignableFrom(stepType))
        {
            Debug.LogError("Invalid step type: " + stepType);
            return;
        }
    }

    void ShowAddStepMenu()
    {

        menu.ShowAsContext();

    }

    private static Type GetTypeByName(string typeName)
    {
        var t = Type.GetType(typeName);
        if (t != null) return t;

        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            t = asm.GetType(typeName);
            if (t != null) return t;

            t = asm.GetTypes().FirstOrDefault(x => x.Name == typeName);
            if (t != null) return t;
        }
        return null;
    }

    // Helper: call your generic AddStep<T>(string) using reflection
    private void AddStepByType(Type stepType, string defaultDescription)
    {
        var method = typeof(LessonEditorWindow)
            .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
            .First(m =>
                m.Name == nameof(AddStep) &&
                m.IsGenericMethodDefinition &&
                m.GetParameters().Length == 1 &&
                m.GetParameters()[0].ParameterType == typeof(string));

        var generic = method.MakeGenericMethod(stepType);
        generic.Invoke(this, new object[] { defaultDescription });
    }


    public void SelectStep(LessonStep step, int index = -1)
    {
        if (lessonEditor.selectedStep == step)
        {
            if (lessonEditor.selectedStep is LessonSubsequence or GroupLessonStep or BranchLessonStep or LoopStep)
            {
                stackSelectedStep = true;
            }
            else
            {
                Undo.IncrementCurrentGroup();
                string context = $"Unselect {step.Description}";
                Undo.SetCurrentGroupName(context);
                Undo.RecordObject(lessonEditor, context);
                // Undo.RecordObject(lessonEditor.selectedIndex, context);

                lessonEditor.selectedStep = null;
                lessonEditor.selectedIndex = -1;
                EditorUtility.SetDirty(lessonEditor);

            }
        }
        else
        {
            string context = $"Select {step.Description}";
            Undo.SetCurrentGroupName(context);
            Undo.RecordObject(lessonEditor, context);
            lessonEditor.selectedStep = step;
            lessonEditor.selectedIndex = index;
            EditorUtility.SetDirty(lessonEditor);

        }
        if (stepEditor != null)
        {
            DestroyImmediate(stepEditor);
            stepEditor = null;
        }
    }

    private void AddStep<T>(string defaultDescription) where T : LessonStep
    {
        string context = $"Add Lesson Step {typeof(T).Name}";
        Undo.IncrementCurrentGroup(); // Group Undo operations
        Undo.SetCurrentGroupName(context);
        T step = ScriptableObject.CreateInstance<T>();
        step.name = typeof(T).Name + "_" + currentSteps.Count;
        step.Description = defaultDescription;
        // Register creation for Undo

        
        AssetDatabase.AddObjectToAsset(step, currentLessonObject);
        AssetDatabase.SaveAssets();
        Undo.RegisterCreatedObjectUndo(step, context);
        Undo.RegisterFullObjectHierarchyUndo(currentLessonObject, context);

        // Add to the list and register Undo for the Lesson
        // Undo.RecordObject(currentLessonObject, context);

        if (lessonEditor.selectedIndex != -1)
            currentSteps.Insert(lessonEditor.selectedIndex + 1, step);
        else
            currentSteps.Add(step);
        
        EditorUtility.SetDirty(currentLessonObject);
        AssetDatabase.Refresh();

        // SelectStep(step, lessonEditor.selectedIndex != -1 ? lessonEditor.selectedIndex + 1 : currentSteps.Count - 1);
    }

    private void RemoveStepRecursive(int index, ScriptableObject LessonObject = null, string context = null)
    {
        var stack = new List<Tuple<ScriptableObject, int, bool>>();
        stack.Add(new Tuple<ScriptableObject, int, bool>(LessonObject, index, false));
        Debug.Log($"Stack count start: {stack.Count}");
        while (stack.Count > 0)
        {
            var (current, idx, processed) = stack[stack.Count-1];
            stack.RemoveAt(stack.Count - 1);
            Debug.Log($"Processing removal of step at index {idx} from {(current != null ? current.name : "lessonSO")}, processed={processed}");
            if (current != null)
                LessonObject = current;
            else
                LessonObject = currentLessonObject;
            index = idx;
            var stepsField = LessonObject.GetType().GetField("steps");
            if (stepsField == null || stepsField.FieldType != typeof(List<LessonStep>))
                return;

            var steps = stepsField.GetValue(LessonObject) as List<LessonStep>;
            if (steps == null || index < 0 || index >= steps.Count)
                return;

            var stepToRemove = steps[index];

            if (context == null)
            {
                context = $"Remove Lesson Step {stepToRemove.GetType().Name}";
                Undo.IncrementCurrentGroup();
                Undo.SetCurrentGroupName(context);

            }

            if (!processed)
            {
                stack.Add(new Tuple<ScriptableObject, int, bool>(LessonObject, index, true));
                // If it's a GroupLessonStep or LessonSubsequence, remove its sub-steps recursively
                if (stepToRemove is GroupLessonStep or LessonSubsequence)
                {
                    var subStepsField = stepToRemove.GetType().GetField("steps");
                    var subSteps = subStepsField?.GetValue(stepToRemove) as List<LessonStep>;
                    for (int i = subSteps.Count - 1; i >= 0; i--)
                    {
                        stack.Append(new Tuple<ScriptableObject, int, bool>(stepToRemove, i, false));
                    }
                }
            }
            else
            {
                // Now remove the step itself
                Undo.RecordObject(LessonObject, context);
                steps.RemoveAt(index);
                Undo.DestroyObjectImmediate(stepToRemove);
                AssetDatabase.SaveAssets();
                EditorUtility.SetDirty(LessonObject);
                AssetDatabase.Refresh();

                // If the removed step was selected, clear the selection
                if (lessonEditor.selectedStep == stepToRemove)
                {
                    lessonEditor.selectedStep = null;
                    lessonEditor.selectedIndex = -1;
                    if (stepEditor != null)
                    {
                        DestroyImmediate(stepEditor);
                        stepEditor = null;
                    }
                }
            }


        }
    }

    private void RemoveStep(int index)
    {
        var step = currentSteps[index];
        currentSteps.RemoveAt(index);

        Object.DestroyImmediate(step, true);
        AssetDatabase.SaveAssets();
        EditorUtility.SetDirty(currentLessonObject);
        AssetDatabase.Refresh();

        if (lessonEditor.selectedStep == step)
        {
            lessonEditor.selectedStep = null;
            lessonEditor.selectedIndex = -1;
            if (stepEditor != null)
            {
                DestroyImmediate(stepEditor);
                stepEditor = null;
            }
        }
    }

    private void SelectSubStep(LessonStep subStep)
    {
        selectedSubStep = subStep;
        if (stepEditor != null)
        {
            DestroyImmediate(stepEditor);
            stepEditor = null;
        }
    }

    private void SelectTab(LessonStep step)
    {
        lessonEditor.selectedStep = null;
        lessonEditor.selectedIndex = -1;
        while (lessonStack.Count > 1 && lessonStack[lessonStack.Count - 1] != step)
        {
            lessonStack.RemoveAt(lessonStack.Count - 1);
        }
    }

    private void OnDisable()
    {
        if (stepEditor != null)
        {
            DestroyImmediate(stepEditor);
            stepEditor = null;
        }

        if (libraryEditor != null)
        {
            DestroyImmediate(libraryEditor);
            libraryEditor = null;
        }
    }

}