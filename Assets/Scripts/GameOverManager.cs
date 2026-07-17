using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOver;
    public int lives = 3;
    private bool isDead;

    public void Start()
    {
        gameOver.SetActive(false);
    }

    public void GameOver()
    {
        if (lives <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
            isDead = true;
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
