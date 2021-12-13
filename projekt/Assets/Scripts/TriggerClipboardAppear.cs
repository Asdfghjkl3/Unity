using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerClipboardAppear : MonoBehaviour
{
    public Canvas clipboard;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GlobalVariables.gamePause = true;
            clipboard.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }
    }
}
