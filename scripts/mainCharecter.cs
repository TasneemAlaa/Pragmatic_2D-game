using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainCharecter : MonoBehaviour {


    public float maxSpeed = 1.5f;

    private Animator anim;
    
    public Transform ro;
    private bool speed = false;

    void Start()
    {
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "chest")

        {
            maxSpeed = 0;
            speed = false;
            //Instantiate(anim, ro.position, ro.rotation);
            //chardissap = true;
            //anim.SetBool("rotate", chardissap);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //AudioMAnager.instance.musicSource.Stop();

        }


    }



     public void checkDialogue()
    {
        speed = true;
        anim.SetBool("speed", speed);
    }

}
