using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayOfWeek : MonoBehaviour
{
    public TextMeshProUGUI nameOfDay;
    private int currentDay = 0;
    private string dayDisplay;

    public List<string> day = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

    // Start is called before the first frame update
    void Start()
    {
        nameOfDay.text = day[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CurrentDay()
    {
        currentDay++;
        if (currentDay == 1)
        {
            dayDisplay = day[1];
        }
        else if (currentDay == 2)
        {
            dayDisplay = day[2];
        }
        else if (currentDay == 3)
        {
            dayDisplay = day[3];
        }
        else if (currentDay == 4)
        {
            dayDisplay = day[4];
        }
        else if (currentDay == 5)
        {
            dayDisplay = day[5];
        }

        nameOfDay.text = dayDisplay;
    }
}
