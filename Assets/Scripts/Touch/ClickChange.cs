using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClickChange : MonoBehaviour {
	public float dis=0;
	public string scene1;
	public string scene2;
    public string sub;
    public float subDelay;
    public string newBGM;
    public float delay;
    public bool loop=true;
    public int effectIndex = -1;
    void OnMouseOver () {
		if((Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))&& Player.current.GetXPosition()-transform.position.x<=dis&&Player.current.GetXPosition()-transform.position.x>=-dis){
            SceneChanger.Change(scene2, scene1,sub,subDelay,newBGM,delay,loop,effectIndex);
		}
	}
}
