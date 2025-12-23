using UnityEngine;
using XNode;

[CreateNodeMenu("Lesson/End")]
public class EndNode : Node {
    [Input] public int prev;
}