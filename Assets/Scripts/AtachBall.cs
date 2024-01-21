using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtachBall : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRb != null)
            {
                // Make the ball a child of the player
                collision.transform.parent = transform;

                // Freeze the rotation of the ball through its rigid body
                ballRb.freezeRotation = true;
            }
        }
    }
}
