using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinfo : MonoBehaviour {

    public GameObject Panel;

	void Start () {
        Panel.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void openPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
}
