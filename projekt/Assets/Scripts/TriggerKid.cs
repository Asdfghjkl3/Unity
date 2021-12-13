using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKid : MonoBehaviour
{
    public GameObject kid;
    public GameObject kidCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kid.transform.localScale = new Vector3(2, 2, 2);
            kid.transform.Translate(new Vector3(0f, 1.5f, 0f));
            Destroy(kidCollider);
            Debug.Log("DZIECIAK");
        }  
    }
}
