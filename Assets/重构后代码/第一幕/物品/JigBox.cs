using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigBox : MonoBehaviour {

		public void OnMouseOver(){ 
			if ((Input.GetMouseButtonDown(1)||Input.GetMouseButtonDown(0))&&ItemSystem.GetCurrentItem()=="电闸零件") {
				EBrake.brakeIsOn = false;
                EBrake.isNotOver = true;
				++EBrake.counter;
			}
		}
}
