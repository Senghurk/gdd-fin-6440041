using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Scene names - update these to match your actual scene names
    private const string DRIVING_SCENE = "DrivingGameScene";
    private const string FLYING_SCENE = "FlyingGameScene";
    private const string SUMO_SCENE = "SumoBallGameScene";

    // Button click methods
    public void OnMadDriverClick()
    {
        Debug.Log("Loading Driving Game...");
        SceneManager.LoadScene(DRIVING_SCENE);
    }

    public void OnFlyLikeABirdClick()
    {
        Debug.Log("Loading Flying Game...");
        SceneManager.LoadScene(FLYING_SCENE);
    }

    public void OnSumoAndBallClick()
    {
        Debug.Log("Loading Sumo Game...");
        SceneManager.LoadScene(SUMO_SCENE);
    }

    public void OnExitClick()
    {
        Debug.Log("Exiting game...");

        // If running in Unity Editor
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}