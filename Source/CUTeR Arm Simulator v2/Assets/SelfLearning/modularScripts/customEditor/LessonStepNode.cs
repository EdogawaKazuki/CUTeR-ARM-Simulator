using UnityEngine;
using XNode;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

[CreateNodeMenu("Lesson/Step")]
public class LessonStepNode : Node
{
    [Input] public int prev; 
    [Output] public int next;    

    [SerializeField]
    public LessonStep step; // Reference to your ScriptableObject step

    public string Description => step ? step.Description : "";

}