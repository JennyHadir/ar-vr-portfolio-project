using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    /// Enemy and Player score variables.
    public int enemyScore;
    public int playerScore;

    /// Booleans to determine if is a player or enemy.
    public bool IsPlayer;
    public bool IsEnemy;

    /// Score points images to fill according
    /// to the score 
    public Image point0;
    public Image point1;
    public Image point2;

    // Update is called once per frame
    void Update()
    {
        enemyScore = ScoreHolder.enmyScore;
        playerScore = ScoreHolder.plyrScore;

        if (enemyScore == 1 && IsEnemy)
        {
            point0.fillAmount = 1;
        }
        else if (enemyScore == 2 && IsEnemy)
        {
            point0.fillAmount = 1;
            point1.fillAmount = 1;
        }
        else if (enemyScore == 3 && IsEnemy)
        {
            point0.fillAmount = 1;
            point1.fillAmount = 1;
            point2.fillAmount = 1;
        }
        if (playerScore == 1 && IsPlayer)
        {
            point0.fillAmount = 1;
        }
        else if (playerScore == 2 && IsPlayer)
        {
            point0.fillAmount = 1;
            point1.fillAmount = 1;
        }
        else if (playerScore == 3 && IsPlayer)
        {
            point0.fillAmount = 1;
            point1.fillAmount = 1;
            point2.fillAmount = 1;
        }
    }
}
