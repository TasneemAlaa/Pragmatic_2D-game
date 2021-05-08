using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour {

    public bool isFacingRight = false;
    public float maxSpeed = 3f;
    public int damage;

    public AudioClip hit1;
    public AudioClip hit2;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);

    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="player")
        {
            //AudioMAnager.instance.RandomizeSfx(hit1, hit2);
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
        }
        
    }
}
