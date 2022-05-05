using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySound : MonoBehaviour
{
    /// Background music.
    public GameObject bgSound;

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(bgSound);
    }
}
