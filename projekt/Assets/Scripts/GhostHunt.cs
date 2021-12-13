using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostHunt : MonoBehaviour
{
    public GameObject ghost;
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if(GlobalVariables.startHunting)
        {
            ghost.transform.LookAt(player.transform.position);
            ghost.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * GlobalVariables.ghostSpeed);
            
        }
    }
}
