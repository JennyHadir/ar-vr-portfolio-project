using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterAnimation playerAnim;
    private Rigidbody rb;
    public float walkSpeed = 2f;
    private float rotationY = -90f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponentInChildren<CharacterAnimation>();
    }

    // Update is called once per frame
    private void Update()
    {
        RotatePlayer();
        AnimatePlayerWalk();
    }

    void FixedUpdate()
    {
        DetectMovement();
    }

    // Movement
    void DetectMovement()
    {
        rb.velocity = new Vector3(
            Input.GetAxisRaw("Horizontal") * (-walkSpeed),
            rb.velocity.y,
            rb.velocity.z);
    }

    // Rotation
    void RotatePlayer()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0f, -Mathf.Abs(rotationY), 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotationY), 0f);
        }
    }

    void AnimatePlayerWalk()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            playerAnim.Walk(true);
        }
        else
        {
            playerAnim.Walk(false);
        }
    }
    
}
