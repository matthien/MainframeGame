using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource audioSource;

    private float musicVolume = 1f;
    void Start()
    {
        audioSource.Play();
    }

    void Update()
    {
        audioSource.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
