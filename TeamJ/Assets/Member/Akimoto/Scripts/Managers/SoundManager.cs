using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource[] audioSourceArray = new AudioSource[1];

    private void Awake()
    {
        for (int i = 0; i < audioSourceArray.Length; i++)
        {
            audioSourceArray[i] = gameObject.AddComponent<AudioSource>();
        }
    }

    private AudioSource GetUnsedAudioSource()
    {
        for(int i = 0; i < audioSourceArray.Length; i++)
            if (audioSourceArray[i].isPlaying == false)
                return audioSourceArray[i];
        return null;
    }

    public void PlaySE(AudioClip clip)
    {
        AudioSource audioSource = GetUnsedAudioSource();
        if(audioSource == null)
            return;
        audioSource.clip = clip;
        audioSource.Play();
    }
}
