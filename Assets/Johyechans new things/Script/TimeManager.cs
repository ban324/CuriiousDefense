using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float currenttime = 0;
    private float waittime = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerM>().timeslow)
        {
            currenttime += Time.unscaledDeltaTime;
        }
        else if (GameObject.Find("Player").GetComponent<PlayerM>().timefast)
        {
            currenttime += Time.unscaledDeltaTime;
        }
        if (currenttime >= waittime)
        {
            GameObject.Find("Player").GetComponent<PlayerM>().timeslow = false;
            GameObject.Find("Player").GetComponent<PlayerM>().timefast = false;
            currenttime = 0;
            Time.timeScale = 1f;
        }
    }
}
