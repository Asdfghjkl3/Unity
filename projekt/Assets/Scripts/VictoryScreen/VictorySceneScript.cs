using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictorySceneScript : MonoBehaviour
{
    
    void Start()
    {
        GlobalVariables.keyCount = 0;
        GlobalVariables.ghostSpeed = 1.5f;
        GlobalVariables.startHunting = false;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
