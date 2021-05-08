using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour {

    public GameObject MessagePanel;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OpenMessagePanel(string msg)
    {
        MessagePanel.SetActive(true);
    }

    void CloseMessagePanel(string msg)
    {
        MessagePanel.SetActive(false);
    }
}
