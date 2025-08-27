using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int score;
    private String scoreString;
    public TMP_Text scoreText;
    void Start()
    {
        score = 0;
        scoreText.text = $"SCORE\n000";
    }

    public void ScoreUpdate(int pointVal)
    {
        score += pointVal;
        if (score < 100)
        {
            scoreString = score.ToString("D3");
        }
        else
        {
            scoreString = score.ToString();
        }
        scoreText.text = $"SCORE\n{scoreString}";
    }
}
