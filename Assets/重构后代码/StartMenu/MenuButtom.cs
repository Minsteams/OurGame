using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtom : MonoBehaviour {
    static public bool MenuOn = false;
    static public bool On = false;
    private void OnMouseDown()
    {
        MenuOn = true;
        SceneManager.LoadScene("菜单界面", LoadSceneMode.Additive);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&On)
        {
            if (MenuOn)
            {
                SceneManager.UnloadSceneAsync("菜单界面");
                MenuOn = false;
            }
            else
            {
                MenuOn = true;
                SceneManager.LoadScene("菜单界面", LoadSceneMode.Additive);
            }
        }
    }
}
