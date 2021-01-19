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
    int ktoryClock;
    int win;
    public void onStart()
    {
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
        if (hour >= 24)
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
            hour = 23;
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
                win = 1;
            }
        }
        else if (ktoryClock == 2)
        {
            if (hour == 7 && minute == 15)
            {
                win = 1;
            }
        }
        else if (ktoryClock == 3)
        {
            if (hour == 9 && minute == 0)
            {
                win = 1;
            }
        }
        else if (ktoryClock == 4)
        {
            if (hour == 4 && minute == 5)
            {
                win = 1;
            }
        }
        else if (ktoryClock == 5)
        {
            if (hour == 4 && minute == 45)
            {
                win = 1;
            }
        }
        else if (ktoryClock == 6)
        {
            if (hour == 10 && minute == 55)
            {
                win = 1;
            }
        }
        SceneManager.LoadScene("SampleScene");
    }
}
