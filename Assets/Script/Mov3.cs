using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov3 : MonoBehaviour
{
    Rigidbody MyRigidBody;
    // Use this for initialization
    void Start()
    {
        MyRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MyRigidBody.velocity = Vector3.right * 5;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            MyRigidBody.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MyRigidBody.velocity = -Vector3.right * 5;
        }
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
