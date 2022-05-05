using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScene : MonoBehaviour
{
    //Seconds to read the audio.
    public float time;

    // Announcer Audio.
    public GameObject announcerAudioSource;


    // Start is called before the first frame update
    IEnumerator Start ()
    {

        yield return new WaitForSeconds(time);
        announcerAudioSource.SetActive(true);
        
    }
}
