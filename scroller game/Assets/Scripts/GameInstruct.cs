using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstruct : MonoBehaviour
{
    public GameObject gameInstruct;
    public float stopTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > stopTime)
        {
            gameInstruct.SetActive(false);
        }
    }
}
