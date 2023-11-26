using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        //movement
        //input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        //move
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
