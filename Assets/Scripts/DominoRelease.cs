using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoRelease : MonoBehaviour {

    // Use this for initialization

    Rigidbody rb;
    GameObject domino;
	void Start () {
        domino = GameObject.Find("Domino5");
        rb = domino.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pendulum")
        {
            rb.isKinematic = false;
        }
    }
}
