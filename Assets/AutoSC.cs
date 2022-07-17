using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoSC : MonoBehaviour {
    public Text a;
	// Use this for initialization
	void Start () {
        StartCoroutine(Delay());
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
    IEnumerator Delay()
    {
        while (true)
        {
            a.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            yield return new WaitForSeconds(1);
            
            
        }
    }
		
	
}
