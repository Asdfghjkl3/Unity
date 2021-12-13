using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLights : MonoBehaviour
{
    

    void Start()
    {
        

    }

    void Update()
    {
        GameObject myLight0_0 = GameObject.Find("light0_0");
        GameObject myLight0_1 = GameObject.Find("light0_1");

        GameObject myLight1_0 = GameObject.Find("light0_0");
        GameObject myLight1_1 = GameObject.Find("light0_1");

        GameObject myLight2_0 = GameObject.Find("light2_1");
        GameObject myLight2_1 = GameObject.Find("light2_2");

        GameObject myLight3_0 = GameObject.Find("light3_0");
        GameObject myLight3_1 = GameObject.Find("light3_0");

        GameObject myLight4_0 = GameObject.Find("light4_0");
        GameObject myLight4_1 = GameObject.Find("light4_1");

        GameObject myLight5_0 = GameObject.Find("light5_0");
        GameObject myLight5_1 = GameObject.Find("light5_1");

        GameObject myLight6_0 = GameObject.Find("light6_0");
        GameObject myLight6_1 = GameObject.Find("light6_1");

        GameObject myLight7_0 = GameObject.Find("light7_0");
        GameObject myLight7_1 = GameObject.Find("light7_1");

        GameObject myLight8_0 = GameObject.Find("light8_0");
        GameObject myLight8_1 = GameObject.Find("light8_1");

        GameObject myLight9_0 = GameObject.Find("light9_0");
        GameObject myLight9_1 = GameObject.Find("light9_1");

        GameObject myLight10_0 = GameObject.Find("light10_0");
        GameObject myLight10_1 = GameObject.Find("light10_1");

        GameObject myLight11_0 = GameObject.Find("light11_0");
        GameObject myLight11_1 = GameObject.Find("light11_1");

        GameObject myLight12_0 = GameObject.Find("light12_0");
        GameObject myLight12_1 = GameObject.Find("light12_1");

        GameObject myLight13_0 = GameObject.Find("light13_0");
        GameObject myLight13_1 = GameObject.Find("light13_1");

        if (GlobalVariables.keyCount == 1)
        {
            myLight0_0.GetComponent<Light>().enabled = false;
            myLight0_1.GetComponent<Light>().enabled = false;

            myLight1_0.GetComponent<Light>().enabled = false;
            myLight1_1.GetComponent<Light>().enabled = false;

            myLight2_0.GetComponent<Light>().enabled = false;
            myLight2_1.GetComponent<Light>().enabled = false;
            myLight13_0.GetComponent<Light>().enabled = false;
            myLight13_1.GetComponent<Light>().enabled = false;
            myLight11_0.GetComponent<Light>().enabled = false;
            myLight11_1.GetComponent<Light>().enabled = false;
        }
        else if(GlobalVariables.keyCount == 2)
        {
            myLight0_0.GetComponent<Light>().enabled = false;
            myLight0_1.GetComponent<Light>().enabled = false;

            myLight1_0.GetComponent<Light>().enabled = false;
            myLight1_1.GetComponent<Light>().enabled = false;

            myLight2_0.GetComponent<Light>().enabled = false;
            myLight2_1.GetComponent<Light>().enabled = false;

            myLight3_0.GetComponent<Light>().enabled = false;
            myLight3_1.GetComponent<Light>().enabled = false;

            myLight4_0.GetComponent<Light>().enabled = false;
            myLight4_1.GetComponent<Light>().enabled = false;

            myLight5_0.GetComponent<Light>().enabled = false;
            myLight5_1.GetComponent<Light>().enabled = false;

            myLight6_0.GetComponent<Light>().enabled = false;
            myLight6_1.GetComponent<Light>().enabled = false;

            myLight7_0.GetComponent<Light>().enabled = false;
            myLight7_1.GetComponent<Light>().enabled = false;
        }
        else if(GlobalVariables.keyCount == 3)
        {
            myLight0_0.GetComponent<Light>().enabled = false;
            myLight0_1.GetComponent<Light>().enabled = false;

            myLight1_0.GetComponent<Light>().enabled = false;
            myLight1_1.GetComponent<Light>().enabled = false;

            myLight2_0.GetComponent<Light>().enabled = false;
            myLight2_1.GetComponent<Light>().enabled = false;

            myLight3_0.GetComponent<Light>().enabled = false;
            myLight3_1.GetComponent<Light>().enabled = false;

            myLight4_0.GetComponent<Light>().enabled = false;
            myLight4_1.GetComponent<Light>().enabled = false;

            myLight5_0.GetComponent<Light>().enabled = false;
            myLight5_1.GetComponent<Light>().enabled = false;

            myLight6_0.GetComponent<Light>().enabled = false;
            myLight6_1.GetComponent<Light>().enabled = false;

            myLight7_0.GetComponent<Light>().enabled = false;
            myLight7_1.GetComponent<Light>().enabled = false;

            myLight8_0.GetComponent<Light>().enabled = false;
            myLight8_1.GetComponent<Light>().enabled = false;

            myLight9_0.GetComponent<Light>().enabled = false;
            myLight9_1.GetComponent<Light>().enabled = false;

            myLight10_0.GetComponent<Light>().enabled = false;
            myLight10_1.GetComponent<Light>().enabled = false;

            myLight11_0.GetComponent<Light>().enabled = false;
            myLight11_1.GetComponent<Light>().enabled = false;

            myLight12_0.GetComponent<Light>().enabled = false;
            myLight12_1.GetComponent<Light>().enabled = false;

            myLight13_0.GetComponent<Light>().enabled = false;
            myLight13_1.GetComponent<Light>().enabled = false;
        }
    }
}
