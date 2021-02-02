using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TaskCoop_01A : MonoBehaviour
{
    public TextMeshProUGUI sliderText;
    public TextMeshProUGUI display1;
    public TextMeshProUGUI display2;
    public TextMeshProUGUI display3;
    public TextMeshProUGUI display4;
    public TextMeshProUGUI display5;
    public TextMeshProUGUI display6;

    public void Slider_Changed(float newValue)
    {
        sliderText.SetText(newValue.ToString() + "%");
    }

    public void exitTask()
    {   
        if (display1.text == (NetworkController.dis1.ToString() + "%") &&
            display2.text == (NetworkController.dis2.ToString() + "%") &&
            display3.text == (NetworkController.dis3.ToString() + "%") &&
            display4.text == (NetworkController.dis4.ToString() + "%") &&
            display5.text == (NetworkController.dis5.ToString() + "%") &&
            display6.text == (NetworkController.dis6.ToString() + "%")){
            NetworkController.taskDoneCoop1 = true;
        }
        SceneManager.LoadScene("SampleScene");
    }
}
