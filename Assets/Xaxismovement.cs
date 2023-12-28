using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAxisMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    
    void Update()
    {
        // Get input from arrow keys (X-axis movement)
        float xInput = Input.GetAxis("Horizontal");

        // Calculate the movement in the X-axis
        Vector3 movement = new Vector3(xInput, 0, 0) * moveSpeed * Time.deltaTime;

        // Move the object in the X-axis
        transform.Translate(movement);

        // Display the object's position along the X-axis in the console
        float posX = transform.position.x;

        Debug.Log("X-axis value: " + posX);
    }
}

