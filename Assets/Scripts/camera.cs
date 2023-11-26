using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player; // Reference to the player object
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Offset to adjust the camera position

    void Update()
    {
        if (player != null)
        {
            // Calculate the target position for the camera
            Vector3 targetPosition = player.position + offset;

            // Smoothly move the camera towards the target position using Lerp
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);
        }
    }
}
