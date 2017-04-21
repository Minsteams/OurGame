using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using Colorful;

public class CameraEffectChange : MonoBehaviour {
    public string[] effectList;
    static bool[,] effectBool;
    static GameObject current;
	// Use this for initialization
	void Awake () {
        current = this.gameObject;
        effectBool = new bool[effectList.Length,10];
        for(int i = 0; i < effectList.Length; i++)
        {
            int temp = System.Convert.ToInt32(effectList[i], 2);
            for(int j = 9;j>=0 ; j--)
            {
                effectBool[i, j] = ((temp & 1)== 1);
                temp /= 2;
            }
        }
	}
    static public void ChangeEffect(int index)
    {
        current.GetComponent<BloomAndFlares>().enabled = effectBool[index, 0];
        current.GetComponent<BloomOptimized>().enabled = effectBool[index, 1];
        current.GetComponent<Glitch>().enabled = effectBool[index, 2];
        current.GetComponent<WhiteBalance>().enabled = effectBool[index, 3];
        current.GetComponent<SCurveContrast>().enabled = effectBool[index, 4];
        current.GetComponent<VintageFast>().enabled = effectBool[index, 5];
        current.GetComponent<Bloom>().enabled = effectBool[index, 6];
        current.GetComponent<MotionBlur>().enabled = effectBool[index, 7];
        current.GetComponent<GrainyBlur>().enabled = effectBool[index, 8];
        current.GetComponent<GrainyEffect>().enabled = effectBool[index, 8];
        current.GetComponent<ShadowsMidtonesHighlights>().enabled = effectBool[index, 9];
    }
}
