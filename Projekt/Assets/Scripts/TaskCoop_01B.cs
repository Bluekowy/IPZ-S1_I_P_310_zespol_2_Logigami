using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TaskCoop_01B : MonoBehaviour
{

    public TextMeshProUGUI display1;
    public TextMeshProUGUI display2;
    public TextMeshProUGUI display3;
    public TextMeshProUGUI display4;
    public TextMeshProUGUI display5;
    public TextMeshProUGUI display6;

    void Start()
    {
        display1.SetText(NetworkController.dis1.ToString() + "%");
        display2.SetText(NetworkController.dis2.ToString() + "%");
        display3.SetText(NetworkController.dis3.ToString() + "%");
        display4.SetText(NetworkController.dis4.ToString() + "%");
        display5.SetText(NetworkController.dis5.ToString() + "%");
        display6.SetText(NetworkController.dis6.ToString() + "%");
    }

    public void exitTask()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
