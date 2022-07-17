using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mov2 : MonoBehaviour {
    public float movementspeed;
    
	// Use this for initialization
	void Start () {
        movementspeed = 15f;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementspeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementspeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate (0, 5f, 0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate (0, -5f, 0);
        }
       if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3 (13,0,-44);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
    }
    public void clickAction() {
        transform.position = new Vector3 (13,5,-44);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
