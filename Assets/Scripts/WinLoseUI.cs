using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class WinLoseUI : MonoBehaviour
{
    [SerializeField]
    private Text WinLoseText;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private GameObject WLCanvas;

    // Player and enemy hp variables.
    private float PlayerHP;
    private float EnemyHP;

    // Player and Enemy scores variables.
    public int enemyScore;
    public int playerScore;

    // IsDead boolean to determine which player is dead.
    private bool IsDead;

    // Rounds Canvas.
    public GameObject roundsUi;


    // Awake is called once the game begin.
    private void Awake()
    {
        enemyScore = ScoreHolder.enmyScore;
        playerScore = ScoreHolder.plyrScore;
        IsDead = false;
        Invoke("DisplayRounds", 0f);
    }
    
    // Update is called once per frame.
    void Update()
    {
        Invoke("DisableRounds", 2f);
        PlayerHP = player.GetComponent<Health>().health;
        EnemyHP = enemy.GetComponent<Health>().health;

        if (EnemyHP == 0 && IsDead == false)
        {
            enemy.GetComponent<EnemyMovement>().enabled = false;
            player.GetComponent<PlayerMovement>().enabled = false;
            IsDead = true;
            playerScore = ScoreHolder.pScore();
            if (playerScore == 3)
            {
                WinLoseText.text = "YOU WIN!";
                WLCanvas.SetActive(true);
                Invoke("MenuLoader", 4f);
            }
            else
            {
                Invoke("SceneLoader", 4f);
            }
        }
        else if (PlayerHP == 0 && IsDead == false)
        {
            enemy.GetComponent<EnemyMovement>().enabled = false;
            player.GetComponent<PlayerMovement>().enabled = false;
            IsDead = true;
            enemyScore = ScoreHolder.eScore();
            if (enemyScore == 3)
            {
                WinLoseText.text = "YOU LOSE!";
                WLCanvas.SetActive(true);
                Invoke("MenuLoader", 4f);
            }
            else
            {
                Invoke("SceneLoader", 4f);
            }
        }
    }

    // Display rounds canvas
    public void DisplayRounds()
    {
        roundsUi.SetActive(true);
    }

    // Disable rounds canvas
    public void DisableRounds()
    {
        roundsUi.SetActive(false);
    }

    //Load a scene method
    public void SceneLoader()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Load a menu method
    public void MenuLoader()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
