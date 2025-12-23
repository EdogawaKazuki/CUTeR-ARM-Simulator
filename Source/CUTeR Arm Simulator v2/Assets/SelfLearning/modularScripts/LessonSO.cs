using UnityEngine;
using System.Collections.Generic;

// Defines an abstract base class named LessonStep that inherits from Unity's ScriptableObject.

[CreateAssetMenu(menuName = "Lesson/LessonSequence")]
public class LessonSO : ScriptableObject
{
    public List<LessonStep> steps;
}