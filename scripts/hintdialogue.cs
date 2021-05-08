using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintdialogue : MonoBehaviour {
   // public Dialogue dialogueManager;
    public AudioClip popupsound;
    //private SpriteRenderer spriteRenderer;

    //public Sprite instructor;

    public GameObject pickUptext;

    void Start()
    {
        
        pickUptext.gameObject.SetActive(false);

        /*if (PlayerStats.lives == 1)
         {
             string[] dialogue3 =
               {  " PAUL be careful you only havE one live left to complete your mission, otherwise you will be trapped here forever!!"
                  };
             dialogueManager.SetSentences(dialogue3);
             dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
         }
     }*/

    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerStats.lives==1)
        {
            AudioMAnager.instance.RandomizeSfx(popupsound);
            pickUptext.gameObject.SetActive(true);
            Destroy(pickUptext, 3f);
        }
    }


   
}
