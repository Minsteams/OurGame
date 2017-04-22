using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrossInMenu : MonoBehaviour {
    private void OnMouseDown()
    {
        MenuButtom.MenuOn = false;
        SceneManager.UnloadSceneAsync("菜单界面");
    }
}
