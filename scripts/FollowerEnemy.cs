using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : Enemycontroller
{
    private player player;
    

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, maxSpeed * Time.deltaTime);


    }

}