using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TimerManager timeManager;

    // Update is called once per frame
    void Update()
    {
        if ((GameObject.FindGameObjectWithTag("Player") == null) && (timeManager.timer < 10))
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
