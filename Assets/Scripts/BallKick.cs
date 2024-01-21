using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallKick : MonoBehaviour
{
    public float kickForce = 20f; // Adjust the kick force as needed

    private bool isAttachedToPlayer = true;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isAttachedToPlayer)
            {
                // Detach the ball from the player
                transform.parent = null;
                isAttachedToPlayer = false;

                // Get the direction the player is facing
                Vector3 playerDirection = Camera.main.transform.forward;

                // Apply force to the ball in the direction the player is facing
                rb.AddForce(playerDirection * kickForce, ForceMode.Impulse);
            }
            else
            {
                // Reset the ball's position and make it a child of the player again
                transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2f; // Adjust the offset as needed
                transform.parent = Camera.main.transform;
                isAttachedToPlayer = true;
            }
        }
    }
}
