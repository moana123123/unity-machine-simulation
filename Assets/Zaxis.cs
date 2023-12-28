using UnityEngine;

public class ZAxisMovementWithKeys : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    void Update()
    {
        // Get the input for moving along the Z-axis
        float zInput = 0;

        if (Input.GetKey("q"))
        {
            zInput = 1.0f; // Move in positive Z
        }
        else if (Input.GetKey("e"))
        {
            zInput = -1.0f; // Move in negative Z
        }

        // Calculate the movement in the Z-axis
        Vector3 movement = new Vector3(0, zInput,0)* moveSpeed * Time.deltaTime;

        // Move the object in the Z-axis
        transform.Translate(movement);

        // Display the object's position along the Z-axis in the console
        float posZ = transform.position.z;

        Debug.Log("Z-axis value: " + posZ);
    }
}


