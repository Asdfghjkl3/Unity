using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMonologue : MonoBehaviour
{
    public GameObject monologue1;
    public GameObject monologue2;

    private void Start()
    {
        if (monologue1 != null)
        {
            monologue1.GetComponent<Canvas>().enabled = false;
        }
        if(monologue2 != null)
        {
            monologue2.GetComponent<Canvas>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (monologue1 != null || monologue2 != null)
        {
            if (other.CompareTag("Player"))
            {
                if (this.gameObject.name == "MonologueCollider1") StartCoroutine(startMonologue1());
                else if (this.gameObject.name == "MonologueCollider2") StartCoroutine(startMonologue2());
            }
                
        }
    }

    IEnumerator startMonologue1()
    {
        if (monologue1 != null)
        {
            monologue1.GetComponent<Canvas>().enabled = true;

            yield return new WaitForSeconds(3);
            monologue1.GetComponent<Canvas>().enabled = false;
            Destroy(monologue1);
        }
    }

    IEnumerator startMonologue2()
    {
        if (monologue2 != null)
        {
            monologue2.GetComponent<Canvas>().enabled = true;
            yield return new WaitForSeconds(3);
            monologue2.GetComponent<Canvas>().enabled = false;
            Destroy(monologue2);
        }
    }
}
