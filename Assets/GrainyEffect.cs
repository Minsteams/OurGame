using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Colorful;

public class GrainyEffect : MonoBehaviour {
    GrainyBlur gb;
    bool isChanging=false;
    bool isUp=false;
    public int minFrames;
    public int maxFrames;
    int frames;
    int waitFrames;
    float radius;
    public float maxRadius;
    public float deltaRadius;
	// Use this for initialization
	void Start () {
        gb = GetComponent<GrainyBlur>();	
	}
	
	// Update is called once per frame
	void Update () {
        if (isChanging)
        {
            if (isUp)
            {
                gb.Radius += deltaRadius;
                if (gb.Radius >= radius) isUp = false;
            }
            else
            {
                if (gb.Radius < deltaRadius)
                {
                    gb.Radius = 0;
                    isChanging = false;
                    waitFrames = Random.Range(minFrames, maxFrames);
                }
                else
                {
                    gb.Radius -= deltaRadius;
                }
            }
        }
        else
        {
            frames++;
            if (frames >= waitFrames) BlurOnce();
        }
	}
    void BlurOnce()
    {
        frames = 0;
        isChanging = true;
        isUp = true;
        radius = Random.Range(0, maxRadius);
    }
}
