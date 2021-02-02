//using System;
/*using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Task02 : MonoBehaviour
{
    GameObject[] buttons;
    GameObject[] lightArray;
    GameObject[] rowLights;
    int[] lightOrder;
    GameObject Task_02;
    int level = 0;
    int buttonsclicked = 0;
    int colorOrderRunCount = 0;
    bool passed = false;
    bool won = false;
    Color32 red = new Color32(255, 39, 0, 255);
    Color32 green = new Color32(4, 204, 0, 255);
    Color32 invi = new Color32(4, 204, 0, 0);
    Color32 white = new Color32(255, 255, 255, 255);
    public float lightspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        level = 0;
        buttonsclicked = 0;
        colorOrderRunCount = -1;
        won = false;
        for(int i = 0; i < lightOrder.Length; i++)
        {
            lightOrder[i] = (Random.Range(0, 3));
        }
        for(int i = 0; i < rowLights.Length; i++)
        {
            //
        }
        level = 1;
        //StartCoroutine(());
    }
    public void ButtonClickOrder(int button)
    {
        buttonsclicked++;
        if (button == lightOrder[buttonsclicked - 1])
        {
            passed = true;
        }
        else
        {
            won = false;
            passed = false;
            //
        }
        if (buttonsclicked==level && passed ==true && buttonsclicked != 3)
        {
            level++;
            passed = false;
            //
        }
        if (buttonsclicked == level && passed == true && buttonsclicked == 3)
        {
            Debug.Log("fail");
            won = true;
            //
        }
    }


    private IEnumerator ColorOrder()
    {
        buttonsclicked = 0;
        colorOrderRunCount++;
        //
        for(int i = 0; i < colorOrderRunCount; i++)
        {
            if (level >= colorOrderRunCount)
            {
                lightArray[lightOrder[i]].GetComponent<ImageFileMachine>().color = invi;
                yield return new WaitForSecounds(lightspeed);
                lightArray[lightOrder[i]].GetComponent<ImageFileMachine>().color = green;
                yield return new WaitForSecounds(lightspeed);
                lightArray[lightOrder[i]].GetComponent<ImageFileMachine>().color = invi;
                rowLights[i].GetComponent<Image>().color = green;
            }
        }
        //
    }
    void disable
    {

    }
    void enable
    {

    }
}*/
