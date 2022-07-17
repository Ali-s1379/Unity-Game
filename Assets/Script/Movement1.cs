using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour {
   Vector3 offset;
    public Camera Gholam;
    Rigidbody MyRigidBody;
    // Use this for initialization
    void Start () {
        offset = Gholam.transform.position - transform.position;
        MyRigidBody = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            MyRigidBody.AddForce(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        Gholam.transform.position = transform.position + offset;
    }
}
