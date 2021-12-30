using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathScript : MonoBehaviour
{
    public GameObject player;
    public CharacterController2D controller;
    public float speed = 17f;
    public Animator animator;
    public float startingPoint;
    public float endingPoint;
    bool inEnemysRangeX = false;
    bool inEnemysRangeY = false;
    bool inPathStart = false;
    bool inPathEnd = false;


    void Update()
    {
        inEnemysRangeX = (player.transform.position.x >= startingPoint && player.transform.position.x <= endingPoint) ? true : false;
        inEnemysRangeY = (player.transform.position.y >= transform.position.y - 0.1f && player.transform.position.y <= transform.position.y + 3f) ? true : false;
        inPathStart = (transform.position.x < startingPoint && speed < 0) ? true : false;
        inPathEnd = (transform.position.x > endingPoint && speed > 0) ? true : false;


        //Debug.Log(inEnemysRangeX);
        //Debug.Log(inEnemysRangeY);

        if (inEnemysRangeX && inEnemysRangeY)
        {
            speed = (player.transform.position.x < transform.position.x && speed > 0) ? speed *= -1 : speed;
            speed = (player.transform.position.x > transform.position.x && speed < 0) ? speed *= -1 : speed;
        }
        else if (inPathStart || inPathEnd)
        {
            speed *= -1;
        }

        animator.SetFloat("Speed", Mathf.Abs(speed));
        controller.Move(speed * Time.deltaTime, false);


    }
}
