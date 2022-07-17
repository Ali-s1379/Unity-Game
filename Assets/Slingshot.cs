using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slingshot : MonoBehaviour {
    Rigidbody rb;
    public InputField forcefield, anglefield;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void fire()
    {
        int force = int.Parse(forcefield.text);
        int angle = int.Parse(anglefield.text);
        float constant = Mathf.PI / 180f;
        Vector3 angle2 = new Vector3(force * Mathf.Cos(angle * constant), force * Mathf.Sin(angle * constant), 0);
        rb.AddForce(angle2, ForceMode.Impulse);
    }
}
