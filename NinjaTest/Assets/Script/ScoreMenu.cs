using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenu : MonoBehaviour
{
    public Text highScoreMenuDisplay;
    void Update()
    {
        highScoreMenuDisplay.text = PlayerPrefs.GetInt("score").ToString();
    }
}
