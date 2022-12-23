using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayClock : MonoBehaviour
{
    public TextMeshProUGUI clock;
    private float clockTime = 0.0f;
    
    int hours = 9;
    int minutes = 00;
    private bool hasAddHour;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        clockTime += Time.deltaTime * 15f;
        DisplayTime();
    }

    private void DisplayTime()
    {
        print(clockTime);
        if (clockTime is >= 0 and < 15)
        {
            hasAddHour = false;
            minutes = 0;
        }
        else if (clockTime is >= 15 and <= 30)
            minutes = 15;
        else if (clockTime is >= 30 and <= 45)
            minutes = 30;
        else if (clockTime is >= 45 and <= 60)
            minutes = 45;
        else if (clockTime is >= 60)
        {
            if (!hasAddHour)
            {
                hasAddHour = true;
                clockTime = 0;
                minutes = 0;
                hours++;
            }
        }
        
        clock.text = hours.ToString("00") + ":" + minutes.ToString("00");
    }
}
