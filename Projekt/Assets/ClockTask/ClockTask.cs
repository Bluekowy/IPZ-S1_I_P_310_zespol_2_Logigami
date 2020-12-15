using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockTask: MonoBehaviour
{
    public int hour = 0;
    public int minute = 0;
    public TextMeshProUGUI time;

    
    public void changeTime(int x)
    {
        Debug.Log("kliknieto");
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
}
