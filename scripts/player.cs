using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

  public float moveSpeed;
    public float jumpHeight;
    bool isFacingRight;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundCheck;
    public float groundcheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private Animator anim;

    public Transform firePoint;
    public GameObject SpikyBullet;
    public KeyCode f;

    public static int mapscollected = 0;

   
    public AudioClip destroy;

    public static int counter;

    void Start()
    {
        isFacingRight = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Spacebar) && grounded)
        {
            jump();
        }
        if (Input.GetKeyDown(f))
        {
            Instantiate(SpikyBullet, firePoint.position, firePoint.rotation);

        }


        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

            if (isFacingRight)
            {
                flip();
                isFacingRight = false;
            }
        }

        anim.SetFloat("speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (isFacingRight == false)
            {
                flip();
                isFacingRight = true;
            }
        }

            anim.SetBool("grounded", grounded);
       
    }


    void flip()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }

    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        //AudioMAnager.instance.RandomizeSfx(jump1, jump2);
    }


    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundcheckRadius, whatIsGround);
    }

    public void Shoot()
    {
        Instantiate(SpikyBullet, firePoint.position, firePoint.rotation);
    }


  
    void OnTriggerEnter2D(Collider2D other)
    {
       if( other.tag=="cave")
            (new NavigationController()).GoToCaveScene();
      else  if (other.tag == "caveWall")
            (new NavigationController()).GoToDesertoScene();

        if (other.tag == "snowbottle")
        {
            counter++;
            Destroy(this.gameObject);
            AudioMAnager.instance.RandomizeSfx(destroy);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //checkcounter();
    }


   /*void checkcounter()
    {
        if(counter==2)
        {
            (new NavigationController()).Gotocritical();
        }
    }*/
}
