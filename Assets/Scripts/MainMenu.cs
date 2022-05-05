using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    /// Options canvas.
    public GameObject OptionCanvas;
    
    /// Main menu canvas.
    public GameObject MainCanvas;


    // Start the game.
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Load Option scene.
    public void Option()
    {
        MainCanvas.SetActive(false);
        OptionCanvas.SetActive(true);
    }

    // Exit the game.
    public void Quit()
    {
        Application.Quit();
    }
}
