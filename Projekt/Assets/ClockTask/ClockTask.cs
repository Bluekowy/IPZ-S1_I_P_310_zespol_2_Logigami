using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ClockTask: MonoBehaviour
{
    public int hour = 0;
    public int minute = 0;
    public TextMeshProUGUI time;
    public GameObject clock1;
    public GameObject clock2;
    public GameObject clock3;
    public GameObject clock4;
    public GameObject clock5;
    public GameObject clock6;
    public int ktoryClock;

    private void Start()
    {
        ktoryClock = NetworkController.clock;
        if (ktoryClock == 1)
        {
            clock1.SetActive(true);
        }
        else if (ktoryClock == 2)
        {
            clock2.SetActive(true);
        }
        else if (ktoryClock == 3)
        {
            clock3.SetActive(true);
        }
        else if (ktoryClock == 4) 
        {
            clock4.SetActive(true);
        }
        else if (ktoryClock == 5)
        {
            clock5.SetActive(true);
        }
        else if (ktoryClock == 6)
        {
            clock6.SetActive(true);
        }
    }

    public void changeTime(int x)
    {
        minute = minute + x;
        if (minute >= 60)
        {
            minute = minute - 60;
            hour = hour + 1;
        }
        if (hour >= 12)
        {
            hour = 0;
        }
        if (minute < 0)
        {
            hour = hour - 1;
            minute = 60 + minute;
        }
        if (hour < 0)
        {
            hour = 11;
        }
        string hourstr;
        if (hour < 10)
        {
            hourstr = "0" + hour.ToString();
        }
        else
        {
            hourstr = hour.ToString();
        }
        string minstr;
        if (minute < 10)
        {
            minstr = "0" + minute.ToString();
        }
        else
        {
            minstr = minute.ToString();
        }
        time.SetText(hourstr + ":" + minstr);
    }

    public void exitTask()
    {
        if (ktoryClock == 1)
        {
            if (hour == 0 && minute == 45)
            {
                NetworkController.taskDone3 = true;
            }
        }
        else if (ktoryClock == 2)
        {
            if (hour == 7 && minute == 15)
            {
                NetworkController.taskDone3 = true;
            }
        }
        else if (ktoryClock == 3)
        {
            if (hour == 9 && minute == 0)
            {
                NetworkController.taskDone3 = true;
            }
        }
        else if (ktoryClock == 4)
        {
            if (hour == 4 && minute == 5)
            {
                NetworkController.taskDone3 = true;
            }
        }
        else if (ktoryClock == 5)
        {
            if (hour == 4 && minute == 45)
            {
                NetworkController.taskDone3 = true;
            }
        }
        else if (ktoryClock == 6)
        {
            if (hour == 10 && minute == 55)
            {
                NetworkController.taskDone3 = true;
            }
        }
        SceneManager.LoadScene("SampleScene");
    }
}
