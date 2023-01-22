using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip victoryClip;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeMusic()
    {
        audioSource.clip = victoryClip;
        audioSource.Play();
    }
}
