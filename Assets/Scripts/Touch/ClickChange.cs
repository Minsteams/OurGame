﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClickChange : MonoBehaviour {
	public float dis=0;
	public string scene1;
	public string scene2;
	void OnMouseDown () {
		if(Player.current.GetXPosition()-transform.position.x<=dis&&Player.current.GetXPosition()-transform.position.x>=-dis){
            SceneChanger.Change(scene2, scene1);
		}
	}
}
