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

        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (score > PlayerPrefs.GetInt("SavedHighScore"))
            {
                PlayerPrefs.SetInt("SavedHighScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SavedHighScore", score);
        }
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("SavedHighScore", highscore);
            PlayerPrefs.Save(); // Ensures data is written immediately
        }
        finalScoreText.text = scoreText.text;
        highScoreText.text = highScoreText.text;
    }
}
