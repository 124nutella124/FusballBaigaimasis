using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreekickPosition : MonoBehaviour
{
    // Array to store the possible positions
    private Vector3[] ballPositions = new Vector3[]
    {
        new Vector3(13f, 0.5f, -9.75f),
        new Vector3(-13f, 0.5f, -9.75f),
        new Vector3(-2.71f, 0.5f, -2.35f)
    };

    void Start()
    {
        // Get the ball GameObject using its tag
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");

        if (ball != null)
        {
            // Choose a random position from the array
            Vector3 randomPosition = ballPositions[Random.Range(0, ballPositions.Length)];

            // Set the ball's position to the randomly chosen position
            ball.transform.position = randomPosition;

            Debug.Log("Ball positioned at: " + randomPosition);
        }
        else
        {
            Debug.LogError("Ball not found in the scene. Make sure it has the tag 'Ball'.");
        }
    }
}
