using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolder
{
    // Enemy and Player score variables.
    public static int enmyScore = 0;
    public static int plyrScore = 0;

    //eScore increment the enemy score by 1.
    public static int eScore()
    {
        enmyScore++;
        return enmyScore;
    }

    //pScore increment the player score by 1.
    public static int pScore()
    {
        plyrScore++;
        return plyrScore;
    }
}
