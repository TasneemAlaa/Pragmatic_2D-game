using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private SpriteRenderer sr;
    public Sprite explodeblock;
	void Start () {
        sr = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
       		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="player" && other.GetContact(0).point.y<transform.position.y)
        {
            sr.sprite = explodeblock;

            Object.Destroy(gameObject, .2f);
        }
    }
}
