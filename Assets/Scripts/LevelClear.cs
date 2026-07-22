using UnityEngine;
using TMPro;

public class LevelClear : MonoBehaviour
{
    public GameObject levelClear;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;
    public TMP_Text finalTimeText;

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

            ShowResults();

            Time.timeScale = 0f;

            Debug.Log("about time bro");
        }
    }

    void ShowResults()
    {
        // Final score
        if (pointManager != null)
        {
            finalScoreText.text = pointManager.score.ToString();
        }

        // High score
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();

        // Final time
        if (timerController != null)
        {
            finalTimeText.text = timerController.timerText.text;
        }
    }
}