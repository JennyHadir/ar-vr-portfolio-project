using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;

    private CharacterAnimation characterAnimationScript;
    private EnemyMovement enemyMovement;
    private bool characterDied;
    public bool isPlayer;
    private HealthUI healthUI;

    private void Awake()
    {
        characterAnimationScript = GetComponentInChildren<CharacterAnimation>();
        healthUI = GetComponent<HealthUI>();
    }
    
    public void ApplyDamage(float damage, bool knockDown)
    {
        if (characterDied)
            return;

        health -= damage;
        
        healthUI.DisplayHealth(health);

        if (health <= 0)
        {
            characterAnimationScript.Death();
            characterDied = true;

            if (isPlayer)
            {
                //Deactivate enemy script
            }
            return;
        }

        if (!isPlayer)
        {
            if (knockDown)
            {
                if (Random.Range(0, 2) > 0)
                {
                    characterAnimationScript.KnockDown();

                }
            }
            else
            {
                if (Random.Range(0, 3) > 1)
                {
                    characterAnimationScript.Hit();
                }
            }
        }
    }
}
