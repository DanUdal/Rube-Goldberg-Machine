using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultRelease : MonoBehaviour {

    // Use this for initialization
    public bool rotate, fire;
    Vector3 axis, force;
    Transform trans;
    GameObject ammo;
    Rigidbody rb;
    void Start () {
        rotate = false;
        axis = new Vector3(0, 0, 200);
        trans = gameObject.GetComponent<Transform>();
        ammo = GameObject.Find("CatapultAmmo");
        rb = ammo.GetComponent<Rigidbody>();
        force = new Vector3(0, 0, 30);
        fire = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate && (trans.rotation.eulerAngles.z < 90.0f))
        {
            trans.Rotate(axis * Time.deltaTime);
        }
        if ((!(trans.rotation.eulerAngles.z < 89.0f)) && fire)
        {
            rb.velocity = force;
            fire = false;
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CatapultAmmo")
        {
            rotate = true;
        }
    }
}
