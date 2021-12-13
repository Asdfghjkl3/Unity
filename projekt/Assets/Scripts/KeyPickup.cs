using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickup : MonoBehaviour
{
    public GameObject player;
    public Text keyText;
    public AudioSource pickUpSound;

    void Start()
    {
        
    }

    void Update()
    {
        if(keyText != null)
        {
            keyText.text = "Klucze: " + GlobalVariables.keyCount + "/3";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GlobalVariables.keyCount += 1;
            pickUpSound.mute = false;
            pickUpSound.volume = 0.3f;
            GlobalVariables.startHunting = true;

            if(GlobalVariables.keyCount == 2)
            {
                GlobalVariables.ghostSpeed = 2.5f;
                
            }

            else if (GlobalVariables.keyCount == 3)
            {
                GlobalVariables.ghostSpeed = 4f;
            }
            Debug.Log(GlobalVariables.ghostSpeed);

            pickUpSound.Play();
            Destroy(gameObject);
        }
    }
}
