using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public bool IsPlayer;
    public Image healthUI;
    // Start is called before the first frame update
    void Awake()
    {
        if (IsPlayer)
            healthUI = GameObject.FindGameObjectWithTag("HealthUI").GetComponent<Image>();
        else
            healthUI = GameObject.FindGameObjectWithTag("NPCHealthUI").GetComponent<Image>();
    }

    public void DisplayHealth(float value)
    {
        value /= 100f;
        if (value < 0f)
        {
            value = 0f;
        }

        healthUI.fillAmount = value;
    }
}
