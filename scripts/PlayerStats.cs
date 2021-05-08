using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour {

    public static int health = 6;
    public static int lives = 3;

    private float flickerTime = 0f;
    public float flickerDuration = 0.1f; //
    private SpriteRenderer spriteRenderer;

    public bool isImmune = false;
    private float immunityTime = 0f;
    public float immunityDuration = 1.5f; // duration of player's flickering

   // public static int itemscollected = 0;
    //public static int trackitems;


    //public int coinscollected = 0;

    public Slider healthUI;

    public Text livesUI;

    public AudioClip GameOverSound;
    public AudioClip losehealth;
    public AudioClip jewelsound;
    public Sprite instructor;
    public Dialogue dialogueManager;


    //Animator anim;

    void Start () {
        //anim = GetComponent<Animator>();

        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
		
	}
	

   
	// Update is called once per frame
	void Update () {

        healthUI.value = health;
        livesUI.text ="" + lives;

        if(this.isImmune == true)
        {
            Spriteflicker();
            immunityTime = immunityTime + Time.deltaTime;
            if(immunityTime >= immunityDuration)
            {
                this.isImmune = false;
                this.spriteRenderer.enabled = true;
            }
        }
        


    }

    void Spriteflicker()
    {
        if(this.flickerTime < this.flickerDuration)
        {
            this.flickerTime = this.flickerTime + Time.deltaTime;
        }
        else if(this.flickerTime >= this.flickerDuration)
        {
            spriteRenderer.enabled = !(spriteRenderer.enabled);
            this.flickerTime = 0;
        }
    }

    public void TakeDamage(int damage)
    {
        if (this.isImmune == false)
        {
           health = health - damage;
            if (health < 0f)
            {
                health = 0;
            }
            if (health == 0f && lives > 0f)
            {
                FindObjectOfType<LevelManager>().RespawnPlayer();
                health = 6;
                lives--;
                AudioMAnager.instance.RandomizeSfx(losehealth);
               // AudioMAnager.instance.musicSource.Stop();

            }
            if (health == 0 && lives == 0)
            {
               // anim.SetBool("isdead", true);
              
                (new NavigationController()).GoToGameOver();
                Debug.Log("Gameover");
              //  AudioMAnager.instance.RandomizeSfx(GameOverSound);
                //AudioMAnager.instance.musicSource.Stop();
                Destroy(this.gameObject, .5f);


            }
            Debug.Log("Player Health" + health.ToString());
            Debug.Log("Player Lives" + lives.ToString());

            if (lives == 1)
            {
                spriteRenderer.sprite = instructor;
                string[] dialogue =
             {
               " JOHN: Helloo Paul Walker. Welcome to our world PRAGMATIC. ",
               " Paul Walker: Who are you?? and what i am doing here??",

            };
                dialogueManager.SetSentences(dialogue);
                dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
            }

        }
       
 
       PlayHitReaction();
        
    }

    void PlayHitReaction()
    {
        this.isImmune = true;
        this.immunityTime = 0f;
    }

    /*public void collectItem(int itemvalue)
    {
        this.itemscollected = this.itemscollected + itemvalue;
    }*/

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "rock")
            this.transform.parent = other.transform;

        if (other.gameObject.tag == "cave")
            (new NavigationController()).GoToCaveScene();


         if (other.gameObject.tag == "jwall")
        {
            Destroy(this.gameObject, .5f);
            AudioMAnager.instance.RandomizeSfx(losehealth);
            (new NavigationController()).Gotolastscene();
        }
        

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "rock")
            this.transform.parent = null;


    }

   /* public void collectItem(int itemvalue)
    {
        
       itemscollected+= itemvalue;
        trackitems = itemscollected;
    }
    */

        
        
    
    /*
    public void collectbottles()
    {
        energyUI.value = bottlescollected;
        bottlescollected++;
    }*/
}

