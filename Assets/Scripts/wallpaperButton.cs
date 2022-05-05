using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wallpaperButton : MonoBehaviour
{
    // MenuButton method to Load main menu scene
    // once the menu button is clicked.
    public void menuButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
