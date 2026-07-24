using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LevelClear : MonoBehaviour
{
    public GameObject levelClear;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;
    public TMP_Text finalTimeText;
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
        if (pointManager != null)
        {
            finalScoreText.text = "Score: " + pointManager.score;

            int score = pointManager.score;

            if (score > PlayerPrefs.GetInt("SavedHighScore", 0))
            {
                PlayerPrefs.SetInt("SavedHighScore", score);
                PlayerPrefs.Save();
            }

            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("SavedHighScore");
        }

        if (timerController != null)
        {
            finalTimeText.text = timerController.timerText.text;
        }
    }
}