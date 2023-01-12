using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayClock : MonoBehaviour
{
    public DayOfWeek dayOfWeekScript;
    public TextMeshProUGUI clock;
    private double clockTime = 0.0f;
    
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
        //print(clockTime);
        clockTime += Time.deltaTime;
        DisplayTime();
    }

    private void DisplayTime()
    {
        //Time set to a 2 minute playtime, for the level.
        if (clockTime is >= 0 and < 3.75)
        {
            hasAddHour = false;
            minutes = 0;
        }
        else if (clockTime is >= 3.75 and <= 7.5)
            minutes = 15;
        else if (clockTime is >= 7.5 and <= 11.25)
            minutes = 30;
        else if (clockTime is >= 11.25 and <= 15)
            minutes = 45;
        else if (clockTime is >= 15)
        {
            if (!hasAddHour)
            {
                hasAddHour = true;
                clockTime = 0;
                minutes = 0;
                hours++;
                if (hours == 17)
                {
                    dayOfWeekScript.CurrentDay();
                    hours = 9;
                }
            }
        }
        
        clock.text = hours.ToString("00") + ":" + minutes.ToString("00");

        
    }
}
