using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    public GameObject clipboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && GlobalVariables.gamePause == true)
        {
            Time.timeScale = 1;
            clipboard.GetComponent<Canvas>().enabled = false;
        }
    }
}
