using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanFreeze : MonoBehaviour {

    // Use this for initialization
    Rigidbody rb;
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision collision)
    {
        rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

 }
