using System;
using System.Collections;
using System.IO; // For Path and Directory
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.Events;



public class GeneralAudioControl : MonoBehaviour
{
    public AudioSource audioSource;
    private GeneralRobotControl _generalRobotControl;

    public bool skip_audio = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        _generalRobotControl = GetComponent<GeneralRobotControl>();
        Debug.Log("Current working directory: " + System.IO.Directory.GetCurrentDirectory());
    }

    // Update is called once per frame
    void Update() { }

    // public void PlayAudio(AudioClip clip, float volume)
    // {
    //     audioSource.PlayOneShot(clip, volume);

    // }
    public IEnumerator PlayAudioInstant(AudioClip clip, float volume)
    {
        if (!skip_audio)
        {
            audioSource.PlayOneShot(clip, volume);
        }
        return null;
    }

    public IEnumerator StopAudio()
    {
        if (!skip_audio)
        {
            audioSource.Stop();
        }
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
        return null;
    }

    public IEnumerator ResumeAudio()
    {
        audioSource.UnPause(); // Resumes the audio playback
        return null; // Yield to allow the method to be an IEnumerator
    }

    public IEnumerator Wait(float seconds)
    {
        return _generalRobotControl.Wait(skip_audio ? 0f : seconds);
    }

    public AudioClip[] LoadAudios(string path)
    {
        
        // Check if the directory exists
        if (!Directory.Exists(path))
        {
            Debug.LogError($"Directory not found: {path}");
            return new AudioClip[0]; // Return an empty array if the directory does not exist
        }

        // Get all .wav files in the directory
        string[] files = Directory.GetFiles(path, "*.wav");
        // Sort files array alphabetically by filename
        Array.Sort(files, (a, b) => {
            string fileA = Path.GetFileName(a);
            string fileB = Path.GetFileName(b);
            
            // Extract first number from each filename using regex
            var matchA = System.Text.RegularExpressions.Regex.Match(fileA, @"\d+");
            var matchB = System.Text.RegularExpressions.Regex.Match(fileB, @"\d+");
            
            if (matchA.Success && matchB.Success)
            {
                int numA = int.Parse(matchA.Value);
                int numB = int.Parse(matchB.Value);
                return numA.CompareTo(numB);
            }
            
            return string.Compare(fileA, fileB);
        });
        
        AudioClip[] clips = new AudioClip[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            string filePath = files[i];
            string relativePath = filePath.Replace("\\", "/"); // Convert backslashes to forward slashes
            AudioClip clip = Resources.Load<AudioClip>(relativePath);

            if (clip == null)
            {
                // If Resources.Load fails, try loading directly from file
                string audioPath = "file:///" + filePath;
                using (WWW www = new WWW(audioPath))
                {
                    while (!www.isDone) { } // Wait for load to complete
                    
                    if (string.IsNullOrEmpty(www.error))
                    {
                        clip = www.GetAudioClip();
                        clip.name = Path.GetFileNameWithoutExtension(filePath);
                    }
                    else
                    {
                        Debug.LogError($"Error loading audio file {filePath}: {www.error}");
                        continue;
                    }
                }
            }

            clips[i] = clip;
        }

        return clips;
    }
}
