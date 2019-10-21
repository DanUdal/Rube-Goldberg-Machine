using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour {

    // Use this for initialization
    Rigidbody rb;
    Vector3 force, force2;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        force = new Vector3(0, 0, 300);
        force2 = new Vector3(0, 0, -290);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pan3")
        {
            rb.AddForce(force);
        }
        if (collision.gameObject.name == "Trampoline")
        {
            rb.AddForce(force2);
        }
    }
}
