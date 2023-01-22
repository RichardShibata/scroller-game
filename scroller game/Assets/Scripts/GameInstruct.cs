using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstruct : MonoBehaviour
{
    public GameObject gameInstruct;
    public float stopTime;
    public AudioClip startClip;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = startClip;
        PlaySound(startClip);
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > stopTime)
        {
            gameInstruct.SetActive(false);
        }
    }
}
