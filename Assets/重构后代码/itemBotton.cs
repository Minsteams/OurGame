using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBotton : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I)) callItemBlank();
    }
    private void OnMouseDown()
    {
        callItemBlank();
    }
    void callItemBlank()
    {
        if (ItemSystem.current.isShowing)
        {
            ItemSystem.current.HideItemBlank();
        }
        else
        {
            ItemSystem.current.ShowItemBlank();
        }
    }
}
