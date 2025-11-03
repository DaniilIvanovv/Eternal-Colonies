using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("New Game Started");
    }

    public void LoadGame()
    {
        Debug.Log("Loading Game...");
    }

    public void OpenSettings()
    {
        Debug.Log("Opening Settings...");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
