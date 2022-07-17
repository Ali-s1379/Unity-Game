using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z)) {
            GetComponent<Animation>().Play("TR");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Animation>().Play("SC");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Animation>().Play("RO");
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            GetComponent<Animation>().Play();
        }
    }
}
