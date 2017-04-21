using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseIcon : MonoBehaviour {
    static SpriteRenderer sr;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    static Transform t;
    // Use this for initialization
    void Start () {
        t = transform;
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        t.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)+Vector3.forward*10;
	}
    static public void Change(int index)
    {
        Cursor.visible = false;
        switch (index)
        {
            case 0:sr.sprite = null;break;
            case 1:sr.sprite = t.GetComponent<MouseIcon>().s1;break;
            case 2: sr.sprite = t.GetComponent<MouseIcon>().s2; break;
            case 3: sr.sprite = t.GetComponent<MouseIcon>().s3; break;
        }
    }
}
