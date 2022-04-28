using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreDisplay;
    public Text highScoreDisplay;

    public int highScore;
    public int score;

    private void Update()
    {
        highScore = (int)score;
        scoreDisplay.text = highScore.ToString();
        if (PlayerPrefs.GetInt("score") <= highScore)
            PlayerPrefs.SetInt("score", highScore);

        highScoreDisplay.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void Score()
    {
        score++;
    }
}
