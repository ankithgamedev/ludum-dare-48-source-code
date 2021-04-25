using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText;
    float score;
    int highScore;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        score += Time.deltaTime * 5;
        highScore = (int)score;
        scoreText.text = "Score: " + highScore.ToString();

        if (PlayerPrefs.GetInt("score") <= highScore)
        {
            PlayerPrefs.SetInt("score", highScore);
            highscoreText.text = PlayerPrefs.GetInt("score").ToString();
        }

        highscoreText.text = "HighScore: " + PlayerPrefs.GetInt("score").ToString();
    }
}
