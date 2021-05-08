using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : Enemycontroller {
    public float HorizzontalSpeed;
    public float VerticalSpeed;
    public float amplitude;
    private Vector3 temp_position;
    public float moveSpeed;
    private player player;

	// Use this for initialization
	void Start () {
        temp_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        temp_position.x += HorizzontalSpeed;
        temp_position.y = Mathf.Sin(Time.realtimeSinceStartup * VerticalSpeed);
        transform.position = temp_position;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
            FindObjectOfType<PlayerStats>().TakeDamage(damage);

        
    }
}
