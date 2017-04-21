using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AjustMusic : MonoBehaviour {

    public AudioSource[] music;
    public Slider controller;

    // Use this for initialization
    void Start () {
        music[0] = AudioSystem.current.GetComponent<AudioSource>();
        music[1] = AudioSystem.current.BGMSource;
	}
	
	// Update is called once per frame
	void Update () {
        foreach (AudioSource a in music)
        {
            a.volume = controller.value;
        }
	}

}
