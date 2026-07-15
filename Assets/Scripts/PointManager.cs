using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{

    public int score;
    public TMP_Text scoreText;

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
}
