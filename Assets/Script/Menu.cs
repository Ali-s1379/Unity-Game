using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void StartGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
