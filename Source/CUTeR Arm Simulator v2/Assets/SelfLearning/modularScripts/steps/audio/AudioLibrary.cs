using UnityEngine;

// Defines a ScriptableObject that holds a collection of audio clips.
// This can be used to manage and access audio resources in a modular way.
[CreateAssetMenu(menuName = "LessonSteps/Audio/AudioClipLibrary")]
public class AudioClipLibrary : Libraries
{
    public AudioClip[] audioClips;
}