using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TaskCoop_01 : MonoBehaviour
{
    public TextMeshProUGUI sliderText;

    public void Slider_Changed(float newValue)
    {
        sliderText.SetText(newValue.ToString() + "%");
    }

    public void exitTask()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
