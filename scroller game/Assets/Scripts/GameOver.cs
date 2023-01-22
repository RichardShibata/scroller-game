using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TimerManager timeManager;
    public AudioClip loseClip;
    AudioSource audioSource;
    private int playLose = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameObject.FindGameObjectWithTag("Player") == null) && (timeManager.timer < 10))
        {
            playLose += 1;
            if (playLose == 1)
            {
                audioSource.clip = loseClip;
                PlaySound(loseClip);
            }
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
