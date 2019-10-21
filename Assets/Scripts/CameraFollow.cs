using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
    GameObject target, myCamera;
    public Vector3 offset, distance;
    public GameObject[] anchors;
    public GameObject positions;
    public int pos;
    public bool complete, moved;
    public float speed;
    public int length;
	void Start () {
        myCamera = GameObject.Find("SphereCamera");
        target = GameObject.Find("Sphere");
        offset = new Vector3(1.5f, 0.8f, 0);
        myCamera.transform.position = target.transform.position + offset;
        complete = true;
        moved = false;
        distance = new Vector3(6.0f, 2.15f, -1.919f);
        anchors = GameObject.FindGameObjectsWithTag("CameraPosition");
        pos = 0;
        length = anchors.Length;
    }
	
	// Update is called once per frame
	void Update () {
        if (target.transform.position.x < 7.15f)
        {
            complete = false;
            moved = true;
            speed = Time.deltaTime * 2.5f;
            positions = GameObject.Find("Position" + (pos + 1).ToString());
        }
        if ((complete == false) && (pos != length))
        {
            myCamera.transform.position = Vector3.Lerp(myCamera.transform.position, positions.transform.position, speed);
            myCamera.transform.localEulerAngles = Vector3.Lerp(myCamera.transform.rotation.eulerAngles, positions.transform.rotation.eulerAngles, speed);
            if ((myCamera.transform.position - positions.transform.position).magnitude < 0.1)
            {
                pos += 1;
                positions = GameObject.Find("Position" + (pos + 1).ToString());
                speed = Time.deltaTime * 1.7f;
            } 
        }
    }
}
