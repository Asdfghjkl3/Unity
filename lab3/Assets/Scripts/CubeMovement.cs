using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 3.0f;
    private bool endOfPath = false;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(endOfPath)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

            if (transform.position.x >= 10) endOfPath = false;
        }

        if(!endOfPath)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);

            if (transform.position.x <= 0) endOfPath = true;
        }
    }
}
