using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private const string DRIVING_SCENE = "DrivingGameScene";
    private const string FLYING_SCENE = "FlyingGameScene";
    private const string SUMO_SCENE = "SumoBallGameScene";

    public void OnMadDriverClick()
    {
        Debug.Log("Loading Driving Game...");
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadScene(DRIVING_SCENE);
        }
        else
        {
            SceneManager.LoadScene(DRIVING_SCENE);
        }
    }

    public void OnFlyLikeABirdClick()
    {
        Debug.Log("Loading Flying Game...");
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadScene(FLYING_SCENE);
        }
        else
        {
            SceneManager.LoadScene(FLYING_SCENE);
        }
    }

    public void OnSumoAndBallClick()
    {
        Debug.Log("Loading Sumo Game...");
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadScene(SUMO_SCENE);
        }
        else
        {
            SceneManager.LoadScene(SUMO_SCENE);
        }
    }

    public void OnExitClick()
    {
        Debug.Log("Exiting game...");
        if (GameManager.Instance != null)
        {
            GameManager.Instance.QuitGame();
        }
        else
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}