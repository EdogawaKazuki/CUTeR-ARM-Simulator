using UnityEngine;
using UnityEngine.Video;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Reflection;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

[ CreateAssetMenu(menuName = "LessonSteps/StepLibrary")]
public class StepLibrary : LessonStep
{
    [SerializeField]
    public List<string> categories = new List<string>
    {
        "Visual and Audio",
        "Virtual Object",
        "Robot Arm",
        "Matrix",
        "Workflow",
        "Chess",
        "Interaction",
        "Custom",
        "Latex"
    };

    [SerializeField]
    public List<List<string>> stepLibraries = new List<List<string>>();

    public void RefreshStepLibrary()
    {
        stepLibraries.Clear();
        
        // Get all types that inherit from LessonStep
        var lessonStepTypes = GetAllLessonStepTypes();
        
        foreach (var type in lessonStepTypes)
        {
            // Skip the base LessonStep class and this steplibrary class
            if (type == typeof(LessonStep) || type == typeof(StepLibrary))
                continue;
                
            string category = DetermineCategory(type);
            string className = type.Name;
            string displayName = FormatDisplayName(className);
            string description = $"{displayName} Step";
            
            stepLibraries.Add(new List<string> { category, displayName, className, description });
        }
        
        // Sort by category, then by display name
        stepLibraries = stepLibraries.OrderBy(x => x[0]).ThenBy(x => x[1]).ToList();
    }

    private List<Type> GetAllLessonStepTypes()
    {
        var lessonStepTypes = new List<Type>();
        
        // Get all assemblies in the current domain
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            try
            {
                var types = assembly.GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(LessonStep)) && !t.IsAbstract)
                    .ToList();
                lessonStepTypes.AddRange(types);
            }
            catch (ReflectionTypeLoadException)
            {
                // Skip assemblies that can't be loaded
                continue;
            }
        }
        
        return lessonStepTypes;
    }

    private string DetermineCategory(Type type)
    {
        string className = type.Name.ToLower();
        
        // Audio/Video related
        if (className.Contains("audio") || className.Contains("video") || className.Contains("sound") || 
            className.Contains("image") || className.Contains("visual"))
            return "Visual and Audio";
            
        // Virtual objects
        if (className.Contains("virtual") || className.Contains("object") || className.Contains("interpolation"))
            return "Virtual Object";
            
        // Robot arm related
        if (className.Contains("movement") || className.Contains("joint") || className.Contains("trajectory") || 
            className.Contains("robot") || className.Contains("arm") || className.Contains("dhtable") || className.Contains("jacobian"))
            return "Robot Arm";
            
        // Matrix related
        if (className.Contains("matrix") || className.Contains("calculation"))
            return "Matrix";
            
        // Workflow related
        if (className.Contains("group") || className.Contains("parallel") || className.Contains("loop") || 
            className.Contains("sequence") || className.Contains("workflow") || className.Contains("branch"))
            return "Workflow";
            
        // Chess related
        if (className.Contains("chess") || className.Contains("knight") || className.Contains("bishop") || 
            className.Contains("move"))
            return "Chess";

        // Interaction related
        if (className.Contains("interaction") || className.Contains("mcq") || className.Contains("question") ||
            className.Contains("choice"))
            return "Interaction";
            
        // Interaction related
        if (className.Contains("latex") )
            return "Latex";
            
        // Default to Custom
        return "Custom";
    }

    private string FormatDisplayName(string className)
    {
        // Remove "Step" suffix if present
        if (className.EndsWith("Step"))
            className = className.Substring(0, className.Length - 4);
            
        // Add spaces before capital letters (except the first one)
        string result = "";
        for (int i = 0; i < className.Length; i++)
        {
            if (i > 0 && char.IsUpper(className[i]))
                result += " ";
            result += className[i];
        }
        
        return result;
    }
   
    public override IEnumerator Execute(LessonContext ctx)
    {

        yield return null;
    }
}
