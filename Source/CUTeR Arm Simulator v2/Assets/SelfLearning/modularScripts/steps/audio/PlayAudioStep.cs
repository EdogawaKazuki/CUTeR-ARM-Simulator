using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "LessonSteps/Audio/PlayAudio")]
public class PlayAudioStep : LessonStep
{
    [Header("Reference the audio clip library")]
    public AudioClipLibrary audioLibrary;

    [Header("Choose the audio clip from the library")]
    public int audioClipIndex = 0;
    private int previousAudioClipIndex;

    [Header("Volume for the audio clip")]
    [Range(0f, 1f)]
    public float volume = 1f;

    [Header("Start position (seconds)")]
    public float audioStartPosition = 0f;

    [Header("End position (seconds)")]
    public float audioEndPosition;

    // private void OnValidate()
    // {
    //     if (audioLibrary != null && audioLibrary.audioClips != null &&
    //         audioClipIndex >= 0 && audioClipIndex < audioLibrary.audioClips.Length)
    //     {
    //         AudioClip clip = audioLibrary.audioClips[audioClipIndex];
    //         if (clip != null)
    //         {
    //             if (audioEndPosition <= 0f || audioEndPosition > clip.length || previousAudioClipIndex != audioClipIndex)
    //                 audioEndPosition = clip.length; // Default to full length if invalid
    //             Duration = audioEndPosition - audioStartPosition;
    //             if (Duration < 0f) Duration = 0f; // Ensure non-negative
    //         }
    //     }

    //     if (audioClipIndex >= 0)
    //         previousAudioClipIndex = audioClipIndex;
    // }
    public override IEnumerator Execute(LessonContext ctx)
    {
        if (audioLibrary == null || audioLibrary.audioClips == null ||
            audioClipIndex < 0 || audioClipIndex >= audioLibrary.audioClips.Length)
        {
            Debug.LogWarning("PlayAudioStep: Invalid audio clip settings.");
            yield break;
        }

        AudioClip clip = audioLibrary.audioClips[audioClipIndex];
        if (clip == null)
        {
            Debug.LogWarning("PlayAudioStep: Selected AudioClip is null.");
            yield break;
        }
        if (audioEndPosition <= 0f)
        {
            audioEndPosition = clip.length; // Play the full clip by default
        }

        // Clamp and validate positions
        float start = Mathf.Clamp(audioStartPosition, 0, clip.length);
        float end = Mathf.Clamp(audioEndPosition, 0, clip.length);

        if (end <= start)
        {
            Debug.LogWarning("PlayAudioStep: End position must be after start position.");
            yield break;
        }

        float playDuration = end - start;

        // Create a temporary GameObject with AudioSource
        GameObject tempAudio = new GameObject("TempAudioPlayer");
        AudioSource audioSource = tempAudio.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.time = start;
        audioSource.Play();

        // Wait for the desired play duration
        yield return new WaitForSeconds(playDuration);

        audioSource.Stop();
        Object.Destroy(tempAudio);
    }
}