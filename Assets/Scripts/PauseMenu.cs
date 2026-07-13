using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        
    }
}