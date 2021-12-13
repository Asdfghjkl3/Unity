using UnityEngine;
using System.Collections.Generic;
public class PrefabInit : MonoBehaviour
{
    public GameObject myPrefab;
    public List<int> listOfUsedIntegers1 = new List<int>();
    public List<int> listOfUsedIntegers2 = new List<int>();
    void Start()
    {
        System.Random rd = new System.Random();
        
        for(int i = 0; i < 10; i++)
        {
            int rand_num1 = rd.Next(0, 10);
            listOfUsedIntegers1.Add(rand_num1);

            int rand_num2 = rd.Next(0, 10);
            listOfUsedIntegers2.Add(rand_num2);

            Debug.Log(rand_num1 + " " + rand_num2);

            if (!listOfUsedIntegers1.Contains(rand_num1) && !listOfUsedIntegers2.Contains(rand_num2))
            {
                Instantiate(myPrefab, new Vector3(rand_num1, 1, rand_num2), Quaternion.identity);
            }
        }
    }
}
