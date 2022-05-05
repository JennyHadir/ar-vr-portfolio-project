using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    // Timer text variable.
    public Text timerText;

    // Start time variable.
    float startTime;

    // Elapsed time variable.
    float elapsedTime = 0;


    // Start is called before the first frame update.
    void Start()
    {
        startTime = Time.time;
    }

    // TimePassed method to calculat passed time.
    void TimePassed()
    {
        elapsedTime = Time.time - startTime;
        elapsedTime = Mathf.CeilToInt(elapsedTime);
    }

    // Update is called once per frame.
    void Update()
    {
        TimePassed();
        int IntTime = int.Parse(timerText.text);
        if (IntTime > 0)
        {
            timerText.text = (60 - elapsedTime).ToString();
        }
        else
        {
            timerText.text = "0";
        }
    }
}
