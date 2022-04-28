using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text score;
    public ScoreManager sm;

    void Start()
    {
        score.text = ("��� ����: ") + sm.score.ToString();
    }

    public void onClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
}
