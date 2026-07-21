using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameOverManager gameOverManager;

    //pull playerLives script
    private PlayerLives playerLives;

    public TMP_Text finalTimeText;

    void Start()
    {
        playerLives = FindFirstObjectByType<PlayerLives>();
    }
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            // Prevents the timer going below 0
            if (remainingTime < 0)
            {
                remainingTime = 0;
            }
        }
        else
        {
            remainingTime = 0;
            if (playerLives != null)
            {
                playerLives.TimerDeath();
            }
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void ShowFinalTime()
    {
        finalTimeText.text = timerText.text;
    }
}
