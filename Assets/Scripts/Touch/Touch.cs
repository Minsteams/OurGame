using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
	public bool isTouched = false;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTouched = true;
    }
	void OnTriggerExit2D(Collider2D collider){
		isTouched = false;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
