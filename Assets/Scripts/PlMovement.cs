using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 2.0f;

    private float rotationX = 0;
    private float rotationY = 0;

    void Update()
    {
        

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

}
