using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenuScene : MonoBehaviour
{
    /// Option canvas.
    public GameObject OptionCanvas;

    /// Pause canvas.
    public GameObject PCanvas;


    // Back Button
    public void Back()
    {
        OptionCanvas.SetActive(false);
        PCanvas.SetActive(true);
    }
}
