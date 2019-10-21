using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    // Use this for initialization
    float movementx, movementy;
    Rigidbody rb;
    Vector3 force;
    public bool begin;
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        force = new Vector3(0, 0, 0);
        begin = false;
	}
	
	// Update is called once per frame
	void Update () {
        //if (begin)
       // {
            movementx = Input.GetAxis("Horizontal");
            movementy = Input.GetAxis("Vertical");
            force.x = movementx;
            force.z = movementy;
            rb.AddForce(force);
       // }
	}
}
