using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockedDoor : MonoBehaviour {
    public Touch touch;
    // Use this for initialization
    void Start()
    {
        touch = GetComponent<Touch>();
    }

    // Update is called once per frame
    void Update()
    {
        if (touch.isTouched) 
        {
            if (ItemSystem.GetCurrentItem() == "小钥匙")
            {
                ItemSystem.DeleteItem("小钥匙");
                SubtitleSystem.ShowSubtitle("门开惹。");
                GetComponent<LoadScene>().enabled = true;
                Destroy(this);
            }
            else
            {
                touch.isTouched = false;
                SubtitleSystem.ShowSubtitle("锁住惹。");
            }
        }
    }
}
