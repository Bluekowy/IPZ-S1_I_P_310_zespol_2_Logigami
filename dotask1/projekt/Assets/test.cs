//using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public Text cardCode;
    public Text cardCode2;
    public Text cardCode3;
    public Text inputCode;
    public int codeLength = 5;
    public float codeResetTimeInSeconds = 0.5f;
    private bool isResetting = false;
    void Start()
    {
        string code = string.Empty;
        for (int i = 0; i < codeLength; i++)
        {
            code += Random.Range(1, 10);
        }
        cardCode.text = code;
        inputCode.text = string.Empty;

        string code2 = string.Empty;
        for (int j = 0; j < codeLength; j++)
        {
            //code2 = "12345";
            code2 += Random.Range(1, 10);
        }
        cardCode2.text = code2;
        inputCode.text = string.Empty;

        string code3 = string.Empty;
        for (int i = 0; i < codeLength; i++)
        {
            code3 += Random.Range(1, 10);
        }
        cardCode3.text = code3;
        inputCode.text = string.Empty;
    }
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

            inputCode.text += nr;
            if (inputCode.text == cardCode2.text)
            {
                inputCode.text = "Success";
                StartCoroutine(ResetCode());
            }
            //else if (inputCode.text.Length >= codeLength)
            //{
            //    inputCode.text = "Fail";
            //    StartCoroutine(ResetCode());
            //}
            StartCoroutine(ResetCode());
        }
        else if (inputCode.text.Length >= codeLength)
        {
            inputCode.text = "Fail";
            StartCoroutine(ResetCode());
        }
    }
    /*public void Button_Click2(int nr)
    {
        if (isResetting)
        {
            return;
        }
        inputCode.text += nr;
        if (inputCode.text == cardCode2.text)
        {
            inputCode.text = "Success";
            StartCoroutine(ResetCode());
        }
        else if (inputCode.text.Length >= codeLength)
        {
            inputCode.text = "Fail";
            StartCoroutine(ResetCode());
        }
    }
    public void Button_Click3(int nr)
    {
        if (isResetting)
        {
            return;
        }
        inputCode.text += nr;
        if (inputCode.text == cardCode3.text)
        {
            inputCode.text = "Success";
            StartCoroutine(ResetCode());
        }
        else if (inputCode.text.Length >= codeLength)
        {
            inputCode.text = "Fail";
            StartCoroutine(ResetCode());
        }
    }*/
    private IEnumerator ResetCode()
    {
        isResetting = true;
        yield return new WaitForSeconds(codeResetTimeInSeconds);
        inputCode.text = string.Empty;
        isResetting = false;
    }
}