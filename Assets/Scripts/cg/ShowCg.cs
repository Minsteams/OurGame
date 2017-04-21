using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCg : Machine {
    public int index;
	void Start () {
		currentState = new InitState ();
	}

	class InitState:MachineState
	{
		public override void Execute (Machine machine)
		{
			if (machine.IfInteracted ()) {
				GameSystem.IStarted ();
                CGManager.Unlock(machine.GetComponent<ShowCg>().index);
				machine.GetComponent<ShowCg> ().transform.GetChild (0).gameObject.SetActive (true);
				machine.GetComponent<ShowCg> ().transform.GetChild (0).gameObject.transform.position = new Vector3(Player.current.GetXPosition(),0,0);
			}
		}
	}
}