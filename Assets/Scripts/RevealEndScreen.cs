using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealEndScreen : MonoBehaviour {

    // Use this for initialization
    GameObject canvas;
    CanvasGroup EndScreen;
	void Start () {
        canvas = GameObject.Find("EndCanvas");
        EndScreen = canvas.GetComponent<CanvasGroup>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        EndScreen.alpha = 1;
        EndScreen.interactable = true;
    }
}
