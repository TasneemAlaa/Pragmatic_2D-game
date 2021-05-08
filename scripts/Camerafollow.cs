using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour {

    public  Transform Target;
    public  float Cameraspeed;
    public float minX, maxX;
    public float minY, maxY;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

    }

     void FixedUpdate()
    {
        if (Target != null)
        {
            Vector2 newCamposition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * Cameraspeed);
            
            float ClampX = Mathf.Clamp(newCamposition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamposition.y, minY, maxY);

            transform.position = new Vector3(ClampX, ClampY, -10.43f);


        }
    }
}
