using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using System.Numerics;

public class GeneralAudioControl : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void PlayAudio(AudioClip clip, float volume)
    // {
    //     audioSource.PlayOneShot(clip, volume);

    // }
    public IEnumerator PlayAudioInstant(AudioClip clip, float volume)
    {
        audioSource.PlayOneShot(clip, volume);
        return null;
    }

    /* public IEnumerator PlayAudioWait(AudioClip clip, float volume)
    {
        PlayAudioInstant(clip, volume);
        yield return new WaitForSeconds(clip.length);
    } */

    public IEnumerator PauseAudio()
    {
        audioSource.Pause(); // Pauses the audio playback
        return null; // Yield to allow the method to be an IEnumerator
    }

    public IEnumerator ResumeAudio()
    {
        audioSource.UnPause(); // Resumes the audio playback
        return null; // Yield to allow the method to be an IEnumerator
    }
}
