using UnityEngine;
using System.Collections;

// Defines an abstract base class named LessonStep that inherits from Unity's ScriptableObject.
public abstract class LessonStep : ScriptableObject
{
    public string Description;
    public float Duration;
    [SerializeField] public bool isActive = true;
    public abstract IEnumerator Execute(LessonContext ctx);
    public string Group = "";
    public int branch_index = -1;
}