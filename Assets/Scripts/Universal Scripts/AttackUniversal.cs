using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;
    public bool isPlayer, isEnemy;

    public GameObject hitFXPrefab;

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }

    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer); 

        if (hit.Length > 0)
        {
            Vector3 hitFXPos = hit[0].transform.position;
            hitFXPos.y += 1.3f;
            if (hit[0].transform.forward.x > 0)
                hitFXPos.x += 0.3f;
            else if (hit[0].transform.forward.x < 0)
                hitFXPos.x -= 0.3f;

            // If Player
            if (isPlayer)
            {
                Instantiate(hitFXPrefab, hitFXPos, Quaternion.identity);

                if (gameObject.CompareTag("LeftArm") ||
                    gameObject.CompareTag("LeftLeg"))
                {
                    hit[0].GetComponent<Health>().ApplyDamage(damage, true);
                }
                else
                {
                    hit[0].GetComponent<Health>().ApplyDamage(damage, false);
                }
            }

            // If enemy
            if (isEnemy)
            {
                hit[0].GetComponent<Health>().ApplyDamage(damage, false);
                Instantiate(hitFXPrefab, hitFXPos, Quaternion.identity);
            }
            gameObject.SetActive(false);
        }
    }
}
