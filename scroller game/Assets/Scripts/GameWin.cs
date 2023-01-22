using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public TimerManager timeManager;
    public GameObject gameWinPanel;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (timeManager.timer >= 10)
        {
            Destroy(player.gameObject);
            gameWinPanel.SetActive(true);
        }
    }
}
