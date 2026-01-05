using UnityEngine;
using XNode;

[CreateNodeMenu("Lesson/Start")]
public class StartNode : Node {
    [Output] public int next;
}