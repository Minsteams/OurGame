using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGManager : MonoBehaviour {

    static public bool[] isNotLock = new bool[6];

    static public void Unlock(int i)
    {
        isNotLock[i]= true;
        SubtitleSystem.ShowSubtitle("新CG解锁");
    }
}
