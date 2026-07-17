using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    [SerializeField] string sceneName;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0.5f;
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}