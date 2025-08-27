using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GetHighScore : MonoBehaviour
{
    public ScoreManager scoreM;
    [SerializeField] private TextMeshProUGUI highScoreText;
    public string filename;
    private string highScoreFilePath;

    private int highScoreValue;

    private string highScoreString;
    //private const string highScoreFilePath = "High_Score.txt";


    private void Start()
    {
        scoreM = GameObject.Find("Game Manager").GetComponent<ScoreManager>();
        highScoreFilePath = $"{Application.dataPath}{"/TextFiles/"}{filename}.txt";
        Debug.Log($"Loading level file: {highScoreFilePath}");
        highScoreString = ReadHighScore();
        highScoreValue = int.Parse(highScoreString);
        // Chat GPT helped with leading zeros
        if (highScoreValue < 100)
        {
            highScoreString = highScoreValue.ToString("D3");
        }
        highScoreText.text = $"HI-SCORE\n{highScoreString}";
        
       
    }

    private void Update()
    {
       
        // Update txt file is Score manager is higher than high score
        if (scoreM.score > highScoreValue)
        {
            highScoreValue = scoreM.score;
            UpdateHighScore(scoreM.score);
            highScoreString = ReadHighScore();
            if (highScoreValue < 100)
            {
                highScoreString = highScoreValue.ToString("D3");
            }
            highScoreText.text = $"HI-SCORE\n{highScoreString}";
            
        }
    }

    // method to read the files high score
    private string ReadHighScore()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, highScoreFilePath);
        // Log an error if the file doesn't exist
        if (!File.Exists(filePath))
        {
            Debug.LogError($"High score file not found at {filePath}");
            return "000";
        }

        string highScoreString = File.ReadAllText(filePath);
        return highScoreString;
    }
    // method to update the file's high score
    private void UpdateHighScore(int newHighScore)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, highScoreFilePath);
        File.WriteAllText(filePath, newHighScore.ToString());
    }
}
