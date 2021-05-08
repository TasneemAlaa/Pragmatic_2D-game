using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    // Use this for initialization
    public int damage;
 
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "player")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
        }

    }
}
