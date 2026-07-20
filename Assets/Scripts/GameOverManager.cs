using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    [SerializeField] string sceneName;
    public GameObject levelClear;

    void Start()
    {
        gameOverUI.SetActive(false);
        levelClear.SetActive(false);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

    public void LevelClear()
    {
        Time.timeScale = 0;
        levelClear.SetActive(true);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        Application.Quit();
    }
}