using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chest : MonoBehaviour {

   // private SpriteRenderer spriteRenderer;

    public Sprite openchest;
    public Sprite vidogame;
    // public Sprite light;
    public AudioClip transformsound;

    void Start () {
       // spriteRenderer = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" )

        {
            //spriteRenderer.sprite = openchest;
           
            Destroy(this.gameObject);
            AudioMAnager.instance.RandomizeSfx(transformsound);
            // spriteRenderer.sprite = vidogame;

            //Object.Destroy(gameObject, 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            //Destroy(this.gameObject);
        }


    }
}
