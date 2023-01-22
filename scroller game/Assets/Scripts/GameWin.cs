using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public TimerManager timeManager;
    public GameObject gameWinPanel;
    private GameObject player;
    //public AudioSource bgm;
    public AudioClip winClip;
    AudioSource audioSource;
    private int playWin = 0;

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = GetComponent<AudioSource>();
    }

    

    // Update is called once per frame
    void Update()
    {
        if (timeManager.timer >= 10)
        {
            playWin += 1;
            if (playWin == 1)
            {
                audioSource.clip = winClip;
                PlaySound(winClip);
            }

            Destroy(player.gameObject);
            gameWinPanel.SetActive(true);
        }
    }
}
