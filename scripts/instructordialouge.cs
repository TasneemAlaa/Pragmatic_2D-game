using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class instructordialouge : MonoBehaviour {

    // Use this for initialization

    public Dialogue dialogueManager;
    public AudioClip startsound;
    private SpriteRenderer spriteRenderer;

    public Sprite instructor;

    void Start () {

        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

        Scene currentScene = SceneManager.GetActiveScene();
        int sceneIndex = currentScene.buildIndex;

        if (sceneIndex == 2)
        {

            string[] dialogue =
            {  " Paul Walker: ohh what happened!! where am i. and why do i look like this!!",
               " JOHN: Helloo Paul Walker. Welcome to our world PRAGMATIC. ",
               " Paul Walker: Who are you?? and what i am doing here??",
               " John: I am the president of Pragmatic. And you were choosen to help us recue our land. ",
               "John: You are here to help our citizens return back a dimaond tha was stolen by an enemy who controlles all the creatures on this land.",
               "John: So you have to find this diamond in order to return back to your home.",
               "Paul Walker: How can I do this?",
               "John: I will give you a part of a map that will help you in passing the first level, in each level you will find the other part of the map that will lead you to the diamond.",
               "John: But, be carefull, you only have 3 lives to accomplish this mission, if you lost them before reching the diamond you will never return back to your real world.. "

            };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());

            
            

        }

        else if (sceneIndex==8)
        {

            string[] dialogue2 =
                {  " JOHN: Thanks a lot Paul you have completed your mission successfully.",
                   "JOHN:You rescued our world from this enemy. You can now return back to your world. THANKS FOR YOUR HELP.. ",
                 };
            dialogueManager.SetSentences(dialogue2);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
            
        }

        else  if(sceneIndex==11)
        {
            (new NavigationController()).Gotocritical();
            string[] dialogue =
             {
               " JOHN: Great Job Paul, by collecting those energy bottles you finished the level quickly, as they help you in destroying all the enemies in the level.",
                "JOHN: So, you are about to accomplish your mission, GOOD LUCK!"

            };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }

       /* else if( PlayerStats.lives==1)
        {
            string[] dialogue3 =
              {  " PAUL be careful you only have one live left to complete your mission, otherwise you will be trapped here forever!!"
                 };
            dialogueManager.SetSentences(dialogue3);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }*/
    }

    
	
	// Update is called once per frame
	void Update () {
		
	}


public void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "instructorground")

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //(new NavigationController()).GotoVictoryScene();
    }

    if (other.tag == "templeground")

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //(new NavigationController()).GotoVictoryScene();
    }


    /*if (other.tag == "jewel")
    {
        spriteRenderer.sprite = instructor;
        string[] dialogue =
     {
               " JOHN: Hey Paul great job, you are about to complete your mission.. ",
               " JOHN: I am here to give you a hint, that you can find the map of the next level inside the cave. So, you have to enter it. GOOD LUCK!! ",

            };
        dialogueManager.SetSentences(dialogue);
        dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
    }*/


        if (other.tag=="message")
        {
            (new NavigationController()).GoToSnowScene();

        }
    

}
}
