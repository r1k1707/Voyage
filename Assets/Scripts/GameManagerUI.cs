using UnityEngine;

public class GameManagerUI : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }
}
