using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{

    public int score;
    public static int highscore;
    public static int newHighscore;
    public TMP_Text scoreText;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;



    // start makes the score go back to 0
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

   public void UpDateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    // Checks if the current score is higher than the highscore
    public void HighScoreUpdate()
    {
        int savedHighScore = PlayerPrefs.GetInt("SavedHighScore", 0);
        Debug.Log("Current score: " + score);

        if (score > savedHighScore)
        {
            savedHighScore = score;

            PlayerPrefs.SetInt("SavedHighScore", savedHighScore);
            PlayerPrefs.Save();
        }
        finalScoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + savedHighScore;
    }
}
