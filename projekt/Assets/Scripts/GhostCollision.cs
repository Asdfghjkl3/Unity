using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GhostCollision : MonoBehaviour
{
    public GameObject Player;
    public GameObject GhostCollider;
    public GameObject eatenVideo;
    public GameObject videoCanvas;
    public GameObject ghost;

    void Start()
    {
        videoCanvas.GetComponent<Canvas>().enabled = false;
        eatenVideo.GetComponent<VideoPlayer>().enabled = false;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ghost.GetComponents<AudioSource>()[0].mute = true;
            ghost.GetComponents<AudioSource>()[1].mute = true;
            videoCanvas.GetComponent<Canvas>().enabled = true;
            eatenVideo.GetComponent<VideoPlayer>().enabled = true;
            eatenVideo.GetComponent<VideoPlayer>().Play();
            StartCoroutine(GoToEndingScreen());
        }
    }

    IEnumerator GoToEndingScreen()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);
    }
}
