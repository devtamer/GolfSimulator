using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void AboutPage()
    {
        SceneManager.LoadScene("About");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Hole1");
    }
    public void NextLevel2()
    {
        SceneManager.LoadScene("Hole2");
    }
    public void NextLevel3()
    {
        SceneManager.LoadScene("Hole3");
    }

    public void PlayerSelection()
    {
        SceneManager.LoadScene("PlayerSelection");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void doExitGame()
    {
        // save any game data here
#if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
