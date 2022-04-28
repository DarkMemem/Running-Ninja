﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLanguage : MonoBehaviour
{
    private string language;
    Text text;

    public string textRu;
    public string textEng;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        language = PlayerPrefs.GetString("Language");

        if(language == "" || language == "Eng")
        {
            text.text = textEng;
        }
        else
        {
            text.text = textRu;
        }
    }
}
