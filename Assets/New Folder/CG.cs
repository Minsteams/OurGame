using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CG : MonoBehaviour {

    public int ID = 0;
    public GameObject bigPicture;
    public GameObject black;
    SpriteRenderer r;
    public GameObject text1;
    public GameObject text2;

	// Use this for initialization
	void Start () {
        r = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frame
    void Update () {
        if (!CGManager.isLock[ID])
        {
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }

    private void OnMouseUp()
    {
        if (!CGManager.isLock[ID])
        {
            black.SetActive(true);
            bigPicture.SetActive(true);
        }
    }
}
