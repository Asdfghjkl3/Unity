using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Transform player;

    public float sensitivity = 200f;
    float mouseYMove = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseYMove += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * mouseXMove);

        if (mouseYMove > 90) 
        {
            mouseYMove = 90;
        } 
        else if (mouseYMove < -90) 
        {
            mouseYMove = -90;
        }

        transform.localRotation = Quaternion.Euler(-mouseYMove, 0f, 0f);

    }
}