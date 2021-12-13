using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 2.0f;
    int objectCounter = 0;
    public int maxObjects = 10; //Dodana zmienna odpowiadająca za max kostek
    public GameObject block;
    public Material[] materials;
    internal System.Random rand = new System.Random();



    void Start()
    {
        var rend = GetComponent<Renderer>();
        List<int> pozycje_x = new List<int>();
        List<int> pozycje_z = new List<int>();

        for(int i = 0; i < maxObjects; i++)
        {
            pozycje_x.Add(rand.Next((int)rend.bounds.min.x, (int)rend.bounds.max.x));
        }

        for (int i = 0; i < maxObjects; i++)
        {
            pozycje_z.Add(rand.Next((int)rend.bounds.min.z, (int)rend.bounds.max.z));
        }

        for (int i = 0; i < maxObjects; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        //foreach (Vector3 elem in positions)
        //{
        //    Debug.Log(elem);
        //}
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {
       
    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            int randomMaterial = rand.Next(0, 4);
            block.GetComponent<MeshRenderer>().material = materials[randomMaterial];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        StopCoroutine(GenerujObiekt());
    }
}