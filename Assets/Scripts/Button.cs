using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    // Use this for initialization
    bool move;
    Transform trans;
    Vector3 movement;
    CylinderSpin spin;
    GameObject cylinder;
	void Start () {
        move = false;
        trans = gameObject.GetComponent<Transform>();
        movement = new Vector3(0, 0.4f, 0f);
        cylinder = GameObject.Find("Spinner");
        spin = cylinder.GetComponent<CylinderSpin>();
	}
	
	// Update is called once per frame
	void Update () {
		if (move && (trans.position.z < 12.3f))
        {
            trans.Translate(movement * Time.deltaTime);
        }
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ButtonPresser")
        {
            move = true;
            spin.SpinStart();
        }
    }
}
