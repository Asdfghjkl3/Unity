using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScreamOnKeyPickup : MonoBehaviour
{
    public AudioClip scream;
    private bool startScream = true;
    private bool startScream2 = true;
    private bool startScream3 = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.keyCount == 1)
        {
            if(startScream)
            {
                this.GetComponents<AudioSource>()[1].PlayOneShot(scream, 0.3f);
            }
            startScream = false;
        }
        if (GlobalVariables.keyCount == 2)
        {
            this.GetComponents<AudioSource>()[1].pitch = 1f;
            if (startScream2)
            {
                this.GetComponents<AudioSource>()[1].PlayOneShot(scream, 0.3f);
            }
            startScream2 = false;
        }
        if (GlobalVariables.keyCount == 3)
        {
            this.GetComponents<AudioSource>()[1].pitch = 0.6f;
            this.GetComponents<AudioSource>()[1].bypassEffects = true;
            if (startScream3)
            {
                this.GetComponents<AudioSource>()[1].PlayOneShot(scream, 0.3f);
            }

            startScream3 = false;
        }
    }
}
