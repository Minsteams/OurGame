using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGManager : MonoBehaviour {

    static public bool[] isLock;

    private void Awake()
    {
        isLock = new bool[6];
        for(int i = 0; i < 6; i++)
        {
      //      isLock[i] = true;
        }
    }
    static public void Unlock(int i)
    {
        isLock[i]= false;
        SubtitleSystem.ShowSubtitle("新CG解锁");
    }
}
