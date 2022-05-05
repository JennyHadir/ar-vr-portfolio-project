using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{
    public GameObject leftArmAttackPoint, rightArmAttackPoint,
        leftLegAttackPoint, rightLegAttackPoint;

    public float standUpTimer = 2f;

    private CharacterAnimation animationScript;

    private AudioSource audioSource;

    [SerializeField]
    private AudioClip wooshSound, fallSound, groundHitSound, deadSound;

    private ShakeCamera shakeCamera;

    private EnemyMovement enemyMovement;
    private void Awake()
    {
        animationScript = GetComponent<CharacterAnimation>();
        audioSource = GetComponent<AudioSource>();

        if (gameObject.CompareTag("Enemy"))
        {
            enemyMovement = GetComponentInParent<EnemyMovement>();
        }

        shakeCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ShakeCamera>();
    }

    void LeftArmAttackOn()
    {
        leftArmAttackPoint.SetActive(true);
    }

    void LeftArmAttackOff()
    {
        if (leftArmAttackPoint.activeInHierarchy)
            leftArmAttackPoint.SetActive(false);
    }

    void RightArmAttackOn()
    {
        rightArmAttackPoint.SetActive(true);
    }

    void RightArmAttackOff()
    {
        if (rightArmAttackPoint.activeInHierarchy)
            rightArmAttackPoint.SetActive(false);
    }

    void LeftLegAttackOn()
    {
        leftLegAttackPoint.SetActive(true);
    }

    void LeftLegAttackOff()
    {
        if (leftLegAttackPoint.activeInHierarchy)
            leftLegAttackPoint.SetActive(false);
    }

    void RightLegAttackOn()
    {
        rightLegAttackPoint.SetActive(true);
    }

    void RightLegAttackOff()
    {
        if (rightLegAttackPoint.activeInHierarchy)
            rightLegAttackPoint.SetActive(false);
    }

    void TagLeftArm()
    {
        leftArmAttackPoint.tag = "LeftArm";
    }

    void UntagLeftArm()
    {
        leftArmAttackPoint.tag = "Untagged";
    }

    void TagLeftLeg()
    {
        leftLegAttackPoint.tag = "LeftLeg";
    }

    void UntagLeftLeg()
    {
        leftLegAttackPoint.tag = "Untagged";
    }

    void EnemyStandUp()
    {
        StartCoroutine(StandUpAfterTime());
    }

    IEnumerator StandUpAfterTime()
    {
        yield return new WaitForSeconds(standUpTimer);
        animationScript.StandUp();
    }

    public void AttackFXSound()
    {
        audioSource.volume = 0.2f;
        audioSource.clip = wooshSound;
        audioSource.Play();
    }

    public void CharacterDiedSound()
    {
        audioSource.volume = 1f;
        audioSource.clip = deadSound;
        audioSource.Play();
    }

    public void EnemyKnockedDownSound()
    {
        audioSource.clip = fallSound;
        audioSource.Play();
    }

    public void EnemyHitGroundSound()
    {
        audioSource.clip = groundHitSound;
        audioSource.Play();
    }

    void DisableMovement()
    {
        enemyMovement.enabled = false;
        transform.parent.gameObject.layer = 0;
    }

    void EnableMovement()
    {
        enemyMovement.enabled = true;
        transform.parent.gameObject.layer = 7;
    }

    void ShakeCameraOnFall()
    {
        shakeCamera.ShouldShake = true;
    }
}
