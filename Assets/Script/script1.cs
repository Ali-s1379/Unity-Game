using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour {
	float a;
	float b;
	// Use this for initialization
	void Start () {
		a = 0.35f;
		b = 0.35f;
		if(a == b){
			Debug.Log(a + b);
		}
		else{
			Debug.Log(a);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
