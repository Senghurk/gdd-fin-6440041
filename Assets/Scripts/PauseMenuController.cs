using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    private bool isPaused = false;
    private const string MAIN_MENU_SCENE = "MainMenu";

    void Start()
    {
        // Make sure the pause menu is hidden at start
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
        }
        isPaused = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        // Check for Escape key press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(true);
        }
        Time.timeScale = 0f;
        isPaused = true;
        Debug.Log("Game Paused");
    }

    public void Resume()
    {
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
        }
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Game Resumed");
    }

    public void Restart()
    {
        Debug.Log("Restarting current scene...");
        Time.timeScale = 1f;
        // Reload the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void BackToMainMenu()
    {
        Debug.Log("Going back to Main Menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene(MAIN_MENU_SCENE);
    }

    // Clean up when object is destroyed
    void OnDestroy()
    {
        Time.timeScale = 1f;
    }
}