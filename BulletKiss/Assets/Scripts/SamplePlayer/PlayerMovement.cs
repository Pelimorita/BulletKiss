using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Statistics")]
    public static int actualLife = 100;
    public static int points;
    [Header("Player Variables")]
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 6f;
    [SerializeField] private float jump = 7f;
    [SerializeField] private Transform thirdPersonCamera;
    void Update()
    {
        //We get the vector movement components
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontalMove, 0f, verticalMove).normalized;
        //If there is any movement, we have to applied that to our character
        if (direction.magnitude > 0.1f)
        {
            //We calculate the angle of our character camera (we can use the camera to tell the character where to go with + thirdPersonCamera.eulerAngles.y; part
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + thirdPersonCamera.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            //Now we move our character
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }
}
