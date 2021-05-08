using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershooting : MonoBehaviour {

    public KeyCode Return;
    public Transform firepoint;
    public GameObject Spikybullet;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(Return))
        {
            Shoot();
        }
		
	}
    void Shoot()
    {
        Instantiate(Spikybullet, firepoint.position, firepoint.rotation);
    }
}
