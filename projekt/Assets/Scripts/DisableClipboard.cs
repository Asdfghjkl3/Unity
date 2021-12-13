using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableClipboard : MonoBehaviour
{
    public Canvas clipboard;

    void Start()
    {
        clipboard.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        
    }
}
