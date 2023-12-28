using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisMovement : MonoBehaviour
{
    public float moveSpeed = 0.01f;

    void Update()
    {
        // Get the input value for the arrow keys (Z-axis movement)
        float zInput = Input.GetAxis("Vertical");

        // Calculate the movement vector in the Z-axis
        Vector3 movement = new Vector3(0, 0, zInput) * moveSpeed * Time.deltaTime;

        // Move the object in the Z-axis
        transform.Translate(movement);

        // Display the object's position along the Z-axis
        float posZ = transform.position.z;

        Debug.Log("Y axis value: " + posZ);
    }
}

