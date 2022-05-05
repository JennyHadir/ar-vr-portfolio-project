using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rounds : MonoBehaviour
{
    /// Number of rounds.
    public int numberRound;

    /// Enemy and Player score.
    public int enemyScore;
    public int playerScore;

    /// Number of rounds text.
    public Text rounds;

    // Start is called before the first frame update
    void Start()
    {
        enemyScore = ScoreHolder.enmyScore;
        playerScore = ScoreHolder.plyrScore;

        numberRound = playerScore + enemyScore + 1;

        rounds.text = numberRound.ToString();
    }
}
