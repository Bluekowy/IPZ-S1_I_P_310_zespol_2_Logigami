using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TaskCoop_01 : MonoBehaviour
{
    public TextMeshProUGUI sliderText;

    public void Slider_Changed(float newValue)
    {
        sliderText.SetText(newValue.ToString() + "%");
    }
}
