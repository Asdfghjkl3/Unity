using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement3 : MonoBehaviour
{
    public float speed = 7.0f;
    private bool moveLeft = false;
    private bool moveRight = true;
    private bool moveUp = false;
    private bool moveDown = false;
    public Transform from;
    public Transform to;

    private float percentage = 0.51f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        if (moveRight)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

            if (transform.position.x >= 10)
            {
                transform.Rotate(0, 90, 0, Space.World);
                moveRight = false;
                moveDown = true;
            }
            
        }

        if (moveDown)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

            if (transform.position.z <= -10)
            {
                transform.Rotate(0, 90, 0, Space.World);
                moveDown = false;
                moveLeft = true;
            }
        }

        if (moveLeft)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

            if (transform.position.x <= 0)
            {
                transform.Rotate(0, 90, 0, Space.World);
                moveLeft = false;
                moveUp = true;

            }
        }

        if (moveUp)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

            if (transform.position.z >= 0)
            {
                transform.Rotate(0, 90, 0, Space.World);
                moveUp = false;
                moveRight = true;
            }
            
        }
    }
}
