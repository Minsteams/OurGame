using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AMen : Machine {
    static public bool isopen = false;
	// Use this for initialization
	void Start () {
        currentState = new basicState();
	}

    class basicState : MachineState
    {
        public override void Execute(Machine machine)
        {
            if (machine.IfInteracted())
            {
                if (isopen)
                {
                    SceneManager.UnloadSceneAsync("C1S2");
                    SceneChanger.Change("C1S3", "C1S4", "打开门后，一切都变了。", 4, "BGM4", 2, false,4);
                }
                else
                {
                    SubtitleSystem.ShowSubtitle("踹也踹不开，伐开心。");
                }
            }
        }
    }
}
