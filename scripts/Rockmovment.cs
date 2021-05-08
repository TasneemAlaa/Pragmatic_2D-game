using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockmovment : MonoBehaviour {

    float dir_x;
    float movespeed = 3f;
    bool moveRight = true;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x > 8f)
        {
            moveRight = false;
        }
        if(transform.position.x < 3f)
        {
            moveRight = true;

        }

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, transform.position.y);

    }
}
