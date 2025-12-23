using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

public class CreateNewStepMenu

{
    private LessonEditorWindow _window;

    public CreateNewStepMenu(LessonEditorWindow window)
    {
        _window = window;
    }
    public void CreateNewStep(string inputName, string folderName)
    {
        // 1) Guard
        if (string.IsNullOrWhiteSpace(inputName))
        {
            EditorUtility.DisplayDialog("Invalid Name", "Please enter a step name.", "OK");
            return;
        }


        // 2) Sanitize to a valid class name
        string className = MakeValidClassName(inputName);
        string description = $"{className} Step";
        Debug.Log($"Creating new step class: {className}");

        // We don't need to manually add to stepLibraries anymore - RefreshStepLibrary will find it automatically
        // stepLibrary.stepLibraries.Add(new List<string> { folderName, className, className, description });
        Debug.Log("Step will be auto-detected after script creation: " + className);

        // 3) Choose save location (defaults to Assets/LessonSteps)
        string defaultDir = "Assets/LessonSteps";
        if (!AssetDatabase.IsValidFolder(defaultDir))
        {
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Application.dataPath, "LessonSteps"));
            AssetDatabase.Refresh();
        }

        string defaultName = className + ".cs";
        string path = EditorUtility.SaveFilePanelInProject(
            "Create Step Script",
            defaultName,
            "cs",
            "Choose a location for the new step script.",
            defaultDir
        );
        if (string.IsNullOrEmpty(path)) return; // user cancelled

        // Ensure filename matches class name
        string fileNameNoExt = System.IO.Path.GetFileNameWithoutExtension(path);
        if (fileNameNoExt != className)
        {
            string dir = System.IO.Path.GetDirectoryName(path);
            path = System.IO.Path.Combine(dir, className + ".cs").Replace("\\", "/");
        }


        // 4) Build the template and write file
        string fileContents = BuildStepScriptTemplate(className);
        System.IO.File.WriteAllText(path, fileContents, new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

        // 5) Import and open
        Debug.Log("Importing asset at " + path);
        AssetDatabase.ImportAsset(path);
        Debug.Log("Refreshing AssetDatabase...");
        //AssetDatabase.Refresh(); // triggers compile/reload
        var script = AssetDatabase.LoadAssetAtPath<MonoScript>(path);
        Debug.Log("Loaded script: " + script);
        if (script != null) AssetDatabase.OpenAsset(script);

        // 6) Register this step so it appears in ShowAddStepMenu (Step 4)
        //    You can choose a menu path; here we use "Custom/<ClassName>"
        string menuPath = $"Custom/{className}";
        // Description used when instantiating the step later


        // Store class name (no namespace assumed). If your template includes a namespace,
        // store the fully-qualified name instead, e.g., "MyNamespace." + className
        //customSteps.Add((menuPath, className, description));

        // Optional UX tidy-up
        Debug.Log("Refreshing AssetDatabase...");

        // Schedule a refresh of the step library after compilation
        EditorApplication.delayCall += () =>
        {
            _window.StepLibrary.RefreshStepLibrary();
            EditorUtility.SetDirty(_window.StepLibrary);
            AssetDatabase.SaveAssets();
            Debug.Log("Step library refreshed after script creation");
        };
    }
    private string MakeValidClassName(string raw)
    {
        // Trim and replace spaces/hyphens/etc with underscores
        string s = raw.Trim();

        // Remove invalid chars
        s = Regex.Replace(s, @"[^a-zA-Z0-9_]", "_");

        // If starts with digit, prefix with underscore
        if (Regex.IsMatch(s, @"^\d"))
            s = "_" + s;

        // PascalCase common: split on underscores and capitalize
        string[] parts = s.Split(new[] { '_' }, System.StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < parts.Length; i++)
        {
            if (parts[i].Length == 0) continue;
            parts[i] = char.ToUpper(parts[i][0]) + (parts[i].Length > 1 ? parts[i].Substring(1) : "");
        }
        s = string.Join("", parts);

        // Fallback
        if (string.IsNullOrEmpty(s)) s = "NewLessonStep";
        return s;
    }
    
        private string BuildStepScriptTemplate(string className)
        {
            // You can tweak the CreateAssetMenu path to suit your project
            var sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.Collections;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendLine("// add more using statements here if more packages needed");
            sb.AppendLine($"[CreateAssetMenu(menuName = \"LessonSteps/{className}\", fileName = \"{className}\")]");
            sb.AppendLine($"public class {className} : LessonStep");
            sb.AppendLine("{");
            sb.AppendLine("    public override IEnumerator Execute(LessonContext ctx)");
            sb.AppendLine("    {");
            sb.AppendLine("        // write what the step does here");
            sb.AppendLine("        // Example: yield return ctx.SomeOperation();");
            sb.AppendLine("        yield break;");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }

}