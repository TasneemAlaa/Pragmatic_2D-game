using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

    public float speed;
    private player playerchar;
    public GameObject fire;


	void Start () {
        playerchar = FindObjectOfType<player>();

        if(playerchar.transform.localScale.x < 0)
        {
            speed = -speed;
        }
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
		
	}


     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Enemy")
        {
            Destroy(other.gameObject);
            Destroy(fire);
        }
         
    }
}
