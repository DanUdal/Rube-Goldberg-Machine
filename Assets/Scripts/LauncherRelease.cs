using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherRelease : MonoBehaviour {

    // Use this for initialization

    GameObject chain;
    FixedJoint joint;
	void Start () {
        chain = GameObject.Find("Capsule (8)");
        joint = chain.GetComponent<FixedJoint>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pinball")
        {
            Object.Destroy(joint);
        }
    }
}
