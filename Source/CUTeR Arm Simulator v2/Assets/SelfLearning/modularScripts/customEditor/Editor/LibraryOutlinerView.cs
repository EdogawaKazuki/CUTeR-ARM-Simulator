using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using System;

public class LibraryOutlinerView
{
    private Dictionary<string, List<ScriptableObject>> libraryDatabase;
    private Vector2 scrollPosition;

    public LibraryOutlinerView()
    {
        RefreshDatabase();
    }

    public void RefreshDatabase()
    {
        libraryDatabase = new Dictionary<string, List<ScriptableObject>>();
        
        // Find all library assets in the project
        string[] guids = AssetDatabase.FindAssets("t:ScriptableObject");
        
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            var asset = AssetDatabase.LoadAssetAtPath<ScriptableObject>(path);
            
            if (asset != null && IsLibraryType(asset))
            {
                string category = DetermineCategory(asset.GetType());
                
                if (!libraryDatabase.ContainsKey(category))
                    libraryDatabase[category] = new List<ScriptableObject>();
                    
                libraryDatabase[category].Add(asset);
            }
        }
    }

    private bool IsLibraryType(ScriptableObject asset)
    {
        // Check if it inherits from Libraries using reflection
        Type librariesType = null;
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            librariesType = assembly.GetType("Libraries");
            if (librariesType != null) break;
        }
        
        return librariesType != null && librariesType.IsAssignableFrom(asset.GetType());
    }

    private string DetermineCategory(Type type)
    {
        string className = type.Name.ToLower();
        
        if (className.Contains("audio") || className.Contains("sound"))
            return "Audio";
        if (className.Contains("video") || className.Contains("movie"))
            return "Video";
        if (className.Contains("image") || className.Contains("texture"))
            return "Image";
        if (className.Contains("matrix") || className.Contains("dictionary"))
            return "Matrix";
            
        return "Other";
    }

    public void ShowLibrarySelection(System.Action<ScriptableObject> onLibrarySelected, System.Action<System.Type> onCreateNewLibrary)
    {
        GenericMenu menu = new GenericMenu();
        
        
        // Section 2: Create New Libraries
        menu.AddSeparator("");
        menu.AddDisabledItem(new GUIContent("=== Create New Library ==="));
        
        var libraryTypes = GetAllLibraryTypes();
        foreach (var type in libraryTypes)
        {
            var typeLocal = type; // capture for lambda
            string category = DetermineCategory(type);
            string displayName = FormatDisplayName(type.Name);
            
            menu.AddItem(new GUIContent($"{category}/{displayName}"), false,
                () => onCreateNewLibrary(typeLocal));
        }
        
        if (libraryTypes.Count == 0)
        {
            menu.AddDisabledItem(new GUIContent("No library types available"));
        }
        
        menu.AddSeparator("");
        menu.AddItem(new GUIContent("Refresh Database"), false, RefreshDatabase);
        
        menu.ShowAsContext();
    }

    private List<System.Type> GetAllLibraryTypes()
    {
        var libraryTypes = new List<System.Type>();
        
        // Find the Libraries base type by name
        System.Type librariesBaseType = null;
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            try
            {
                librariesBaseType = assembly.GetType("Libraries");
                if (librariesBaseType != null) break;
            }
            catch (System.Reflection.ReflectionTypeLoadException)
            {
                continue;
            }
        }
        
        if (librariesBaseType == null) return libraryTypes;
        
        // Get all types that inherit from Libraries
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            try
            {
                var types = assembly.GetTypes()
                    .Where(t => t.IsSubclassOf(librariesBaseType) && !t.IsAbstract)
                    .ToList();
                libraryTypes.AddRange(types);
            }
            catch (System.Reflection.ReflectionTypeLoadException)
            {
                continue;
            }
        }
        
        return libraryTypes.OrderBy(t => t.Name).ToList();
    }

    private string FormatDisplayName(string typeName)
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

    public void DrawInspectorGUI()
    {
        DrawInspectorGUI(null);
    }
    
    public void DrawInspectorGUI(System.Action<ScriptableObject> onLibrarySelected)
    {
        DrawInspectorGUI(onLibrarySelected, null);
    }
    
    public void DrawInspectorGUI(System.Action<ScriptableObject> onLibrarySelected, ScriptableObject currentlySelected)
    {
        EditorGUILayout.LabelField("Available Libraries", EditorStyles.boldLabel);
        
        if (GUILayout.Button("Refresh Database"))
        {
            RefreshDatabase();
        }
        
        EditorGUILayout.Space();
        
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.MaxHeight(500));
        
        if (libraryDatabase == null || libraryDatabase.Count == 0)
        {
            EditorGUILayout.HelpBox("No library assets found. Create some Libraries using the Add Library button.", MessageType.Info);
        }
        else
        {
            foreach (var category in libraryDatabase.Keys.OrderBy(k => k))
            {
                EditorGUILayout.LabelField(category, EditorStyles.helpBox);
                EditorGUI.indentLevel++;
                
                foreach (var library in libraryDatabase[category].OrderBy(l => l.name))
                {
                    EditorGUILayout.BeginHorizontal();
                    
                    // Highlight if this is the currently selected library
                    bool isSelected = currentlySelected != null && currentlySelected == library;
                    if (isSelected)
                    {
                        GUI.backgroundColor = Color.cyan;
                    }
                    
                    // Show a compact object field
                    GUI.enabled = false;
                    EditorGUILayout.ObjectField(library, typeof(ScriptableObject), false);
                    GUI.enabled = true;
                    
                    // Reset background color
                    if (isSelected)
                    {
                        GUI.backgroundColor = Color.white;
                    }
                    
                    // Edit button to open this library in inspector
                    string buttonText = isSelected ? "Current" : "Edit";
                    GUI.enabled = !isSelected;
                    if (GUILayout.Button(buttonText, GUILayout.Width(50)))
                    {
                        if (onLibrarySelected != null)
                        {
                            // Use the callback if provided
                            onLibrarySelected.Invoke(library);
                        }
                        else
                        {
                            // Fallback to Unity's inspector
                            Selection.activeObject = library;
                            EditorGUIUtility.PingObject(library);
                        }
                    }
                    GUI.enabled = true;
                    
                    EditorGUILayout.EndHorizontal();
                }
                
                EditorGUI.indentLevel--;
                EditorGUILayout.Space();
            }
        }
        
        EditorGUILayout.EndScrollView();
    }
}
