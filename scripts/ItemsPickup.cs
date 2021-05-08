using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemsPickup : MonoBehaviour {

    /*public AudioClip item1;
    public AudioClip item2;*/
   // public int value;

    [SerializeField]
    public GameObject pickUptext;

    public bool pickupallowed;


    void Start () {

        pickUptext.gameObject.SetActive(false);
		
	}

    // Update is called once per frame
    void Update() {

        if (pickupallowed && Input.GetKeyDown(KeyCode.P))
        { 
            pickup();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            /*AudioMAnager.instance.RandomizeSfx(item1, item2);
            FindObjectOfType<PlayerStats>().collectItem(value);
            Destroy(this.gameObject);*/
            pickUptext.gameObject.SetActive(true);
            pickupallowed = true;



        }
       

         
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            /*AudioMAnager.instance.RandomizeSfx(item1, item2);
            FindObjectOfType<PlayerStats>().collectItem(value);
            Destroy(this.gameObject);*/
            pickUptext.gameObject.SetActive(false);
            pickupallowed = false;

        

        }

      

    }

    private void pickup()
    {
        Destroy(gameObject);
       // FindObjectOfType<player>().CollectItem();
        

    }
  



    


}
