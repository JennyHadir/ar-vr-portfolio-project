using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    // Instance of the score class.
    private static GameObject scoreInstance;

    // Awake method called once the game begin.
    void Awake()
    {     
        DontDestroyOnLoad(gameObject);
         
     if (scoreInstance == null) {
         scoreInstance = gameObject;
     } else {
         Destroy(gameObject);
     }
    }
}
