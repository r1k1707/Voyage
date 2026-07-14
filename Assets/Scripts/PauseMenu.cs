 using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    public GameObject pausePanel;

    void Start()
    {

    }

     void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            Debug.Log("Escape key pressed");
            if (!isPaused)
                PauseGame();
            else 
                ResumeGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        isPaused = false;
    }
}