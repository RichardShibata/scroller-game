using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer;
    public float startTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > startTime)
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                timer += 1 * Time.deltaTime;
                timerText.text = ((int)timer).ToString();
            }
        }
    }
}
