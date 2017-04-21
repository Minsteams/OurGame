using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        AudioSystem.ChangeBGM("BGM1");
        Begin.pass = true;
        SceneManager.LoadScene("MainScene");
    }
}
