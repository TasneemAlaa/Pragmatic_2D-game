using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cave : MonoBehaviour {

    [SerializeField]
    public GameObject enteringtext;

    public bool enteringallowed;
    int index;

    void Start()
    {

        enteringtext.gameObject.SetActive(false);
        index = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (enteringallowed && Input.GetKeyDown(KeyCode.E))
            SceneManager.LoadScene(index);
            
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            /*AudioMAnager.instance.RandomizeSfx(item1, item2);
            FindObjectOfType<PlayerStats>().collectItem(value);
            Destroy(this.gameObject);*/
            enteringtext.gameObject.SetActive(true);
            enteringallowed = true;

        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            /*AudioMAnager.instance.RandomizeSfx(item1, item2);
            FindObjectOfType<PlayerStats>().collectItem(value);
            Destroy(this.gameObject);*/
            enteringtext.gameObject.SetActive(false);
            enteringallowed = false;

        }

    }

   /* private void GetIn()
    {
        (new NavigationController()).GoToCaveScene();
    }*/

}
