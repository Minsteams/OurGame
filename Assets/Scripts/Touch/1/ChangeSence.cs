using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeSence : MonoBehaviour {
	public Touch touch;
	public string sceneToLoad;
	public string sceneToUnLoad;
    public string sub;
    public float delaytime;
    public string newBGM;
    public float delay;
    public bool loop=true;
    public int effectIndex=-1;
	// Use this for initialization
	void Start () {
		touch = GetComponent<Touch> ();
	}

	// Update is called once per frame
	void Update () {
		if(touch.isTouched==true){
            SceneChanger.Change(sceneToUnLoad, sceneToLoad, sub, delaytime,newBGM,delay,loop,effectIndex);
		}
	}
}
