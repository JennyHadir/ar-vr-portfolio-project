using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public GameObject OptionCanvas;
    
    // Pause canvas.
    public GameObject PCanvas;

    // Enemy gameobject.
    public GameObject enemy;

    // Player gameobject.
    public GameObject player;

    // Paused boolean to determine if the game is paused.
    bool paused = false;

    // Timer text variable.
    public Text TimerText;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
                Resume();
            else
                Pause();
        }
    }

    // Pause the game
    public void Pause()
    {
        enemy.GetComponent<EnemyMovement>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<PlayerAttack>().enabled = false;
        PCanvas.SetActive(true);
        TimerText.GetComponent<Timer>().enabled = false;
        paused = true;
    }

    // Resume the game
    public void Resume()
    {
        PCanvas.SetActive(false);
        TimerText.GetComponent<Timer>().enabled = true;
        paused = false;
        enemy.GetComponent<EnemyMovement>().enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<PlayerAttack>().enabled = true;
    }

    // Restart the game
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Open Options scene
    public void Options()
    {
        PCanvas.SetActive(false);
        OptionCanvas.SetActive(true);
    }

    // Quit the game
    public void Quit()
    {
        Application.Quit();        
    }
}
