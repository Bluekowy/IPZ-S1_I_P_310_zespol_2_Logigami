﻿using UnityEngine;
using UnityEngine.UI;
public class ChatItemUI : MonoBehaviour
{
    [SerializeField] Text totext;
    public void Initialize(string text)
    {
        totext.text = text;
    }
}
