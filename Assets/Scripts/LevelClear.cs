using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LevelClear : MonoBehaviour
{
    public GameObject levelClear;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;
    public TMP_Text finalTimeText;
    public TMP_Text scoreText;
    public int score;
    public static int highscore;
    private PointManager pointManager;
    private TimerController timerController;

    void Start()
    {
        levelClear.SetActive(false);

        // Find the managers in the scene
        pointManager = FindFirstObjectByType<PointManager>();
        timerController = FindFirstObjectByType<TimerController>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelClear.SetActive(true);
            Time.timeScale = 0f;
            ShowResults();
            Debug.Log("about time bro");
        }
    }

    void ShowResults()
    {
        // Final score
        if (pointManager != null)
        {
            finalScoreText.text = scoreText.text;
        }

        // Final time
        if (timerController != null)
        {
            finalTimeText.text = timerController.timerText.text;
        }
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

        // High score
        highScoreText.text = highScoreText.text;
    }
}