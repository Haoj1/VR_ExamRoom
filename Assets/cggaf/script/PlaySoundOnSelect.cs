using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnSelect : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void PlaySound()
    {
        audioSource.clip = sound;
        audioSource.Play();
    }
}
