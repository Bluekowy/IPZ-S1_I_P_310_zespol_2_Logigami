﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Task01 : MonoBehaviour
{
    public Text cardCode;
    public Text inputCode;
    public int codeLength = 5;
    public float codeResetTimeInSeconds = 0.5f;
    private bool isResetting = false;
    // Start is called before the first frame update
    void Start()
    {
        string code = string.Empty;
        for(int i = 0; i < codeLength; i++)
        {
            code += Random.Range(1,10);
        }
        cardCode.text = code;
        inputCode.text = string.Empty;
    }

    // Update is called once per frame
    public void Button_Click(int nr)
    {
        if (isResetting)
        {
            return;
        }
        inputCode.text += nr;
        if (inputCode.text == cardCode.text)
        {
            inputCode.text = "Success";
            StartCoroutine(ResetCode());
        }
        else if(inputCode.text.Length >= codeLength)
        {
            inputCode.text = "Fail";
            StartCoroutine(ResetCode());
        }
    }
    private IEnumerator ResetCode()
    {
        isResetting = true;
        yield return new WaitForSeconds(codeResetTimeInSeconds);
        inputCode.text = string.Empty;
        isResetting = false;
    }
}