using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OptionsMenu : MonoBehaviour
{
    /// Options Canvas.
    public GameObject OptionCanvas;

    /// Main Menu Canvas.
    public GameObject MainCanvas;


    // Back method disable options canvas and
    /// Enable main menu canvas once back button
    /// is pressed.
    public void Back()
    {
        OptionCanvas.SetActive(false);
        MainCanvas.SetActive(true);
    }
}
