using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour {

    // Use this for initialization
    AudioSource sound;
    GameObject obj;
	void Start () {
        obj = GameObject.Find("SFX");
        sound = obj.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        sound.Play();
    }
}
