using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Door;
    private bool isDetected = false;
    private bool isRunning = false;
    public float distance = 3f;
    private float centerPosition;
    private float rightPosition;
    private bool isOpening = true;
    private bool isClosing = false;
    private float doorSpeed = 6f;

    void Start()
    {
        rightPosition = Door.transform.position.x + distance;
        centerPosition = Door.transform.position.x;
    }

    void Update()
    {
        if (isOpening && Door.transform.position.x >= rightPosition)
        {
            isRunning = false;
        }
        else if (isClosing && Door.transform.position.x <= centerPosition)
        {
            isRunning = false;
        }

        if (isRunning)
        {
            Vector3 move = Door.transform.right * doorSpeed * Time.deltaTime;
            Door.transform.Translate(move);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isDetected = true;

            if (isDetected && Door.transform.position.x <= centerPosition)
            {
                isOpening = true;
                isClosing = false;
                doorSpeed = Mathf.Abs(doorSpeed);
            }

            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isDetected = false;
        if (other.gameObject.CompareTag("Player"))
        {
            if (!isDetected)
            {
                isClosing = true;
                isOpening = false;
                doorSpeed = -doorSpeed;
            }
        }

        

        isRunning = true;
    }
}
