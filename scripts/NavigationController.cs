using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour {

	public void GoToIntroScene()
    {
        Application.LoadLevel(0);
    }

    public void GoSampleScene()
    {
        Application.LoadLevel(1);
    }

    public void GoToIntrductionscene()
    {
        Application.LoadLevel(2);
    }
    public void GoToForest()
    {
        Application.LoadLevel(3);
        PlayerStats.lives = 3;
        PlayerStats.health = 6;
    }
    public void GoToDesertoScene()
    {
        Application.LoadLevel(4);
    }

   public void GoToCaveScene()
    {
        Application.LoadLevel(5);
    }

    public void GoToSnowScene()
    {
        Application.LoadLevel(6);
    }

    public void GoToTemple()
    {
        Application.LoadLevel(7);
    }

    public void Gotolastscene()
    {
        Application.LoadLevel(8);
    }

    public void GotoVictoryScene()
    {
        Application.LoadLevel(9);
    }
    public void GoToGameOver()
    {
        Application.LoadLevel(10);

    }
    public void Gotocritical()
    {
        Application.LoadLevel(11);
    }



    public void Quit()
    {
        Application.Quit();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
