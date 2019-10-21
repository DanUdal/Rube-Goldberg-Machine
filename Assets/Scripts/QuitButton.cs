using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour {
    
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void quit()
    {
        Application.Quit();
    }

    public void reset()
    {
        SceneManager.LoadSceneAsync("BallThing");
    }
}
