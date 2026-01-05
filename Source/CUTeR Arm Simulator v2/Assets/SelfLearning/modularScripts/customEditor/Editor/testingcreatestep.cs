//  private void CreateNewStepScript(string inputName)
//     {
//         // 1) Guard
//         if (string.IsNullOrWhiteSpace(inputName))
//         {
//             EditorUtility.DisplayDialog("Invalid Name", "Please enter a step name.", "OK");
//             return;
//         }


//         // 2) Sanitize to a valid class name
//         string className = MakeValidClassName(inputName);

//         // 3) Choose save location (defaults to Assets/LessonSteps)
//         string defaultDir = "Assets/LessonSteps";
//         if (!AssetDatabase.IsValidFolder(defaultDir))
//         {
//             System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Application.dataPath, "LessonSteps"));
//             AssetDatabase.Refresh();
//         }

//         string defaultName = className + ".cs";
//         string path = EditorUtility.SaveFilePanelInProject(
//             "Create Step Script",
//             defaultName,
//             "cs",
//             "Choose a location for the new step script.",
//             defaultDir
//         );
//         if (string.IsNullOrEmpty(path)) return; // user cancelled

//         // Ensure filename matches class name
//         string fileNameNoExt = System.IO.Path.GetFileNameWithoutExtension(path);
//         if (fileNameNoExt != className)
//         {
//             string dir = System.IO.Path.GetDirectoryName(path);
//             path = System.IO.Path.Combine(dir, className + ".cs").Replace("\\", "/");
//         }

//         // 4) Build the template and write file
//         string fileContents = BuildStepScriptTemplate(className);
//         System.IO.File.WriteAllText(path, fileContents, new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

//         // 5) Import and open
//         AssetDatabase.ImportAsset(path);
//         AssetDatabase.Refresh(); // triggers compile/reload
//         var script = AssetDatabase.LoadAssetAtPath<MonoScript>(path);
//         if (script != null) AssetDatabase.OpenAsset(script);

//         // 6) Register this step so it appears in ShowAddStepMenu (Step 4)
//         //    You can choose a menu path; here we use "Custom/<ClassName>"
//         string menuPath = $"Custom/{className}";
//         // Description used when instantiating the step later
//         string description = $"{className} Step";

//         // Store class name (no namespace assumed). If your template includes a namespace,
//         // store the fully-qualified name instead, e.g., "MyNamespace." + className
//         customSteps.Add((menuPath, className, description));

//         // Optional UX tidy-up
//         newStepName = string.Empty;
//     }


//             private string MakeValidClassName(string raw)
//             {
//                 // Trim and replace spaces/hyphens/etc with underscores
//                 string s = raw.Trim();

//                 // Remove invalid chars
//                 s = Regex.Replace(s, @"[^a-zA-Z0-9_]", "_");

//                 // If starts with digit, prefix with underscore
//                 if (Regex.IsMatch(s, @"^\d"))
//                     s = "_" + s;

//                 // PascalCase common: split on underscores and capitalize
//                 string[] parts = s.Split(new[] { '_' }, System.StringSplitOptions.RemoveEmptyEntries);
//                 for (int i = 0; i < parts.Length; i++)
//                 {
//                     if (parts[i].Length == 0) continue;
//                     parts[i] = char.ToUpper(parts[i][0]) + (parts[i].Length > 1 ? parts[i].Substring(1) : "");
//                 }
//                 s = string.Join("", parts);

//                 // Fallback
//                 if (string.IsNullOrEmpty(s)) s = "NewLessonStep";
//                 return s;
//             }

//         private string BuildStepScriptTemplate(string className)
//         {
//             // You can tweak the CreateAssetMenu path to suit your project
//             var sb = new StringBuilder();
//             sb.AppendLine("using UnityEngine;");
//             sb.AppendLine("using System.Collections;");
//             sb.AppendLine("using System.Collections.Generic;");
//             sb.AppendLine();
//             sb.AppendLine("// add more using statements here if more packages needed");
//             sb.AppendLine($"[CreateAssetMenu(menuName = \"LessonSteps/{className}\", fileName = \"{className}\")]");
//             sb.AppendLine($"public class {className} : LessonStep");
//             sb.AppendLine("{");
//             sb.AppendLine("    public override IEnumerator Execute(LessonContext ctx)");
//             sb.AppendLine("    {");
//             sb.AppendLine("        // write what the step does here");
//             sb.AppendLine("        // Example: yield return ctx.SomeOperation();");
//             sb.AppendLine("        yield break;");
//             sb.AppendLine("    }");
//             sb.AppendLine("}");
//             return sb.ToString();
//         }
//         private void AddStep(System.Type stepType, string defaultDescription)
//         {
//             if (stepType == null || !typeof(LessonStep).IsAssignableFrom(stepType))
//             {
//                 Debug.LogError("Invalid step type: " + stepType);
//                 return;
//             }

//             var step = ScriptableObject.CreateInstance(stepType) as LessonStep;
//             step.name = stepType.Name + "_" + currentSteps.Count;
//             step.Description = defaultDescription;

//             AssetDatabase.AddObjectToAsset(step, currentLessonObject);
//             AssetDatabase.SaveAssets();
//             if (selectedIndex != -1)
//                 currentSteps.Insert(selectedIndex + 1, step);
//             else
//                 currentSteps.Add(step);

//             EditorUtility.SetDirty(currentLessonObject);
//             AssetDatabase.Refresh();

//             SelectStep(step, selectedIndex != -1 ? selectedIndex + 1 : currentSteps.Count - 1);
//         }
//         private void AddStep(System.Type stepType, string defaultDescription)
//         {
//             if (stepType == null || !typeof(LessonStep).IsAssignableFrom(stepType))
//             {
//                 Debug.LogError("Invalid step type: " + stepType);
//                 return;
//             }

//             var step = ScriptableObject.CreateInstance(stepType) as LessonStep;
//             step.name = stepType.Name + "_" + currentSteps.Count;
//             step.Description = defaultDescription;

//             AssetDatabase.AddObjectToAsset(step, currentLessonObject);
//             AssetDatabase.SaveAssets();
//             if (selectedIndex != -1)
//                 currentSteps.Insert(selectedIndex + 1, step);
//             else
//                 currentSteps.Add(step);

//             EditorUtility.SetDirty(currentLessonObject);
//             AssetDatabase.Refresh();

//             SelectStep(step, selectedIndex != -1 ? selectedIndex + 1 : currentSteps.Count - 1);
//         }