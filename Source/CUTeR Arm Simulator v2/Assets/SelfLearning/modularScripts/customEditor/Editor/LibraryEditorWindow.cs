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


public class LibraryEditorWindow : EditorWindow
{
    private ScriptableObject currentLessonObject;
    private LessonStep selectedStep;
    private int selectedIndex = -1;
    private bool stackSelectedStep = false;
    private Editor stepEditor;
    private ScriptableObject selectedLibrary;
    private Editor libraryEditor;
    private Vector2 scroll;
    private LibraryOutlinerView libraryOutliner;

    // --- Grouping UI state ---

    private enum GroupTarget
    {
        Parallel,
        Loop,
        Sequential
    }
    private GroupTarget groupAs = GroupTarget.Parallel;

    // Which existing steps are selected for grouping
    private StepLibrary stepLibrary;

    [MenuItem("Lesson Tools/Library Editor")]

    public static void ShowWindow()
    {
        LibraryEditorWindow window = GetWindow<LibraryEditorWindow>("Library Editor");
        window.minSize = new Vector2(500, 350);
    }
    private void OnEnable()
    {
        stepLibrary = AssetDatabase.LoadAssetAtPath<StepLibrary>("Assets/SelfLearning/Assets/StepLibrary.asset");
        if (stepLibrary != null)
        {
            stepLibrary.RefreshStepLibrary();
            EditorUtility.SetDirty(stepLibrary);
        }

        libraryOutliner = new LibraryOutlinerView();

    }

    private void OnGUI()
    {
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
        GUILayout.Label("Library Editor", LessonEditorStyles.HeaderLabel); // HEADER
        GUI.backgroundColor = prevBg;
        GUI.contentColor = Color.white;


        EditorGUILayout.Space();

        // --- ACTION BUTTONS (accent color)
        var prevContentColor2 = GUI.contentColor;
        // GUI.contentColor = LessonEditorStyles.Accent;


        // Start Library Page
        EditorGUILayout.LabelField("Library Database", LessonEditorStyles.SectionLabel);
        if (GUILayout.Button("Add Library ▼", GUILayout.Width(120)))
        {
            ShowAddLibraryMenu();
        }
        EditorGUILayout.BeginVertical(LessonEditorStyles.StepBox, GUILayout.Height(600));
        if (true)
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Library Database", LessonEditorStyles.SectionLabel);
            EditorGUILayout.BeginVertical(LessonEditorStyles.StepBox, GUILayout.Height(300));
            libraryOutliner.DrawInspectorGUI(OnLibrarySelected, selectedLibrary);
            EditorGUILayout.EndVertical();
            EditorGUILayout.Space();
        }


        // --- LIBRARY INSPECTOR PANEL
        if (selectedLibrary != null)
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Selected Library Editor", LessonEditorStyles.SectionLabel);

            EditorGUILayout.BeginVertical(LessonEditorStyles.StepBox);

            // Show library name and type
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Library:", EditorStyles.boldLabel, GUILayout.Width(60));
            EditorGUILayout.LabelField($"{selectedLibrary.name} ({selectedLibrary.GetType().Name})");

            // Clear selection button
            if (GUILayout.Button("done", GUILayout.Width(50)))
            {
                selectedLibrary = null;
                if (libraryEditor != null)
                {
                    DestroyImmediate(libraryEditor);
                    libraryEditor = null;
                }
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space(5);

            // Show the library's inspector fields
            if (libraryEditor == null)
                libraryEditor = Editor.CreateEditor(selectedLibrary);

            if (libraryEditor != null)
            {
                libraryEditor.OnInspectorGUI();
                if (GUI.changed)
                {
                    EditorUtility.SetDirty(selectedLibrary);
                }
            }
            EditorGUILayout.EndVertical();
        }

        EditorGUILayout.Space();

        EditorGUILayout.EndVertical();
        EditorGUILayout.EndScrollView();
        GUI.backgroundColor = prevBg;
        return;
        

    }



    private void AddStep(System.Type stepType, string defaultDescription)
    {
        if (stepType == null || !typeof(LessonStep).IsAssignableFrom(stepType))
        {
            Debug.LogError("Invalid step type: " + stepType);
            return;
        }
    }


    private void SelectStep(LessonStep step, int index = -1)
    {
        if (selectedStep == step)
        {
            if (selectedStep is LessonSubsequence or GroupLessonStep)
            {
                stackSelectedStep = true;
            }
            else
            {
                selectedStep = null;
                selectedIndex = -1;

            }
        }
        else
        {
            selectedStep = step;
            selectedIndex = index;
        }
        if (stepEditor != null)
        {
            DestroyImmediate(stepEditor);
            stepEditor = null;
        }
    }

    private void RemoveStepRecursive(int index, ScriptableObject LessonObject = null)
    {
        if (LessonObject == null)
            LessonObject = currentLessonObject;

        var stepsField = LessonObject.GetType().GetField("steps");
        if (stepsField == null || stepsField.FieldType != typeof(List<LessonStep>))
            return;

        var steps = stepsField.GetValue(LessonObject) as List<LessonStep>;
        if (steps == null || index < 0 || index >= steps.Count)
            return;

        var stepToRemove = steps[index];

        // If it's a GroupLessonStep or LessonSubsequence, remove its sub-steps recursively
        if (stepToRemove is GroupLessonStep or LessonSubsequence)
        {
            for (int i = steps.Count - 1; i >= 0; i--)
            {
                RemoveStepRecursive(i, stepToRemove);
            }
        }

        // Now remove the step itself
        steps.RemoveAt(index);
        Object.DestroyImmediate(stepToRemove, true);
        AssetDatabase.SaveAssets();
        EditorUtility.SetDirty(LessonObject);
        AssetDatabase.Refresh();

        // If the removed step was selected, clear the selection
        if (selectedStep == stepToRemove)
        {
            selectedStep = null;
            selectedIndex = -1;
            if (stepEditor != null)
            {
                DestroyImmediate(stepEditor);
                stepEditor = null;
            }
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

    // Simple method to show library selection/creation menu
    void ShowAddLibraryMenu()
    {
        // Refresh the library database and show selection menu
        libraryOutliner.RefreshDatabase();
        libraryOutliner.ShowLibrarySelection(OnLibrarySelected, OnCreateNewLibrary);
    }

    // Callback when a library is selected from the database
    private void OnLibrarySelected(ScriptableObject selectedLibrary)
    {
        if (selectedLibrary == null) return;

        // Store the selected library for the editor window
        this.selectedLibrary = selectedLibrary;

        // Clean up previous library editor
        if (libraryEditor != null)
        {
            DestroyImmediate(libraryEditor);
            libraryEditor = null;
        }

        // Create editor for the selected library
        libraryEditor = Editor.CreateEditor(selectedLibrary);

        // Also set it as the active object in Unity's inspector
        Selection.activeObject = selectedLibrary;
        EditorGUIUtility.PingObject(selectedLibrary);

        Debug.Log($"Selected library: {selectedLibrary.name} for editing");
    }

    // Callback when user wants to create a new library on the spot
    private void OnCreateNewLibrary(System.Type libraryType)
    {
        if (libraryType == null) return;

        // Create the ScriptableObject instance
        var newLibrary = ScriptableObject.CreateInstance(libraryType);
        if (newLibrary == null)
        {
            Debug.LogError($"Failed to create instance of {libraryType.Name}");
            return;
        }

        // Set default name and description (similar to how AddStep works)
        string defaultName = FormatLibraryDisplayName(libraryType.Name).Replace(" ", "");
        newLibrary.name = defaultName + "_" + System.DateTime.Now.ToString("HHmmss");

        // Set description using reflection
        var descriptionField = libraryType.GetField("Description");
        if (descriptionField != null && descriptionField.FieldType == typeof(string))
        {
            descriptionField.SetValue(newLibrary, $"New {FormatLibraryDisplayName(libraryType.Name)}");
        }

        // Create default save location (like AddStep does)
        string defaultDir = "Assets/SelfLearning/Assets";
        if (!AssetDatabase.IsValidFolder(defaultDir))
        {
            AssetDatabase.CreateFolder("Assets/SelfLearning", "Assets");
        }

        // Generate automatic path (no dialog - direct creation like AddStep)
        string fileName = newLibrary.name + ".asset";
        string path = System.IO.Path.Combine(defaultDir, fileName);

        // Ensure unique filename if file already exists
        int counter = 1;
        while (AssetDatabase.LoadAssetAtPath<ScriptableObject>(path) != null)
        {
            fileName = newLibrary.name + "_" + counter + ".asset";
            path = System.IO.Path.Combine(defaultDir, fileName);
            counter++;
        }

        // Create the asset file directly (no dialog)
        AssetDatabase.CreateAsset(newLibrary, path);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        // Simply open the new library in inspector for editing
        OnLibrarySelected(newLibrary);

        Debug.Log($"Created new library: {newLibrary.name} at {path}");
    }

    // Helper method to format library display names
    private string FormatLibraryDisplayName(string typeName)
    {
        // Remove common suffixes
        if (typeName.EndsWith("Library"))
            typeName = typeName.Substring(0, typeName.Length - 7);
        if (typeName.EndsWith("Dictionary"))
            typeName = typeName.Substring(0, typeName.Length - 10);

        // Add spaces before capital letters (except the first one)
        string result = "";
        for (int i = 0; i < typeName.Length; i++)
        {
            if (i > 0 && char.IsUpper(typeName[i]))
                result += " ";
            result += typeName[i];
        }

        return result + " Library";
    }

    
}