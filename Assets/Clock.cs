using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public int hour = 0;
    public int minute = 0;
    public TextMeshProUGUI time;

    public void changeTime(int x)
    {
        minute = minute + x;
        if (minute >= 60)
        {
            minute = minute - 60;
            hour = hour + 1;
        }

    }
}
