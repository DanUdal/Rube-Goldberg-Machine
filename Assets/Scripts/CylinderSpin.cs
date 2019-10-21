using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderSpin : MonoBehaviour {

    // Use this for initialization
    public bool spin;
    Transform trans;
    Vector3 rotation;
	void Start () {
        spin = false;
        trans = gameObject.GetComponent<Transform>();
        rotation = new Vector3(0, 0, 60f);
	}
	
	// Update is called once per frame
	void Update () {
		if (spin)
        {
            trans.Rotate(rotation * Time.deltaTime);
        }
	}

    public void SpinStart()
    {
        spin = true;
    }
}
