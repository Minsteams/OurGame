using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryBox : MonoBehaviour {
	public static bool activeBattery = false;

		void OnMouseOver(){ 
			if ((Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0)) && ItemSystem.GetCurrentItem()=="电池") {
				ItemSystem.DeleteItem ("电池");
				EBrake.brakeIsOn = false;
                EBrake.isNotOver = true;
				++EBrake.counter;
			}
		}
}
