using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerRotate : MonoBehaviour {

    // Use this for initialization
    Transform trans, hammerTrans;
    GameObject pivot;
    bool rotate;
    Vector3 axis;
	void Start () {
        pivot = GameObject.Find("HammerPivot");
        trans = pivot.GetComponent<Transform>();
        hammerTrans = gameObject.GetComponent<Transform>();
        rotate = false;
        axis = new Vector3(0, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate)
        {
            hammerTrans.RotateAround(trans.position, axis, -90 * Time.deltaTime);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        rotate = true;
    }
}
