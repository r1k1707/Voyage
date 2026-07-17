    using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOver;
    public int lives = 3;
    private bool isDead;
    [SerializeField] string sceneName;

    public void Start()
    {
        gameOver.SetActive(false);
    }

    public void GameOver()
    {
        if (lives <= 0 && !isDead)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
            isDead = true;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
