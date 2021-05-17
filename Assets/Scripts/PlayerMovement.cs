using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 5;
    public float jumpSpeed = 10;
    public float gravity = 3;

    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        moveDirection.y -= gravity;

        if (controller.isGrounded)
        {
            float moveX = Input.GetAxis("Horizontal");

            moveDirection = new Vector3(moveX * moveSpeed, 0, 0);

            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("Jump");
                moveDirection.y = jumpSpeed;
            }
        }

        controller.Move(moveDirection * Time.deltaTime);
    }
}
