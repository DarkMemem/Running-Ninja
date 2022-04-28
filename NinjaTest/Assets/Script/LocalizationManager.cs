using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationManager : MonoBehaviour
{
    [SerializeField] Image RussianIcon;
    [SerializeField] Image EnglishIcon;
    public string language;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Language"))
        {
            PlayerPrefs.SetString("Language", language);
            Load();
        }
        else
            Load();

        UpdateButtonIcon();
    }
    public void OnButtonClick()
    {
        if (language == "Eng")
        {
            language = "Ru";
            RussianIcon.enabled = true;
            EnglishIcon.enabled = false;
            PlayerPrefs.SetString("Language", language);
        }
        else
        {
            language = "Eng";
            EnglishIcon.enabled = true;
            RussianIcon.enabled = false;
            PlayerPrefs.SetString("Language", language);
        }
        Save();
    }

    private void UpdateButtonIcon()
    {
        if (language == "Eng")
        {
            RussianIcon.enabled = false;
            EnglishIcon.enabled = true;
        }
        else
        {
            EnglishIcon.enabled = false;
            RussianIcon.enabled = true;
        }
    }
    private void Save()
    {
        PlayerPrefs.SetString("Language", language);
    }
    private void Load()
    {
        language = PlayerPrefs.GetString("Language");
    }
}
