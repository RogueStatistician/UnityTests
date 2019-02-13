using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	public Hazard fountain;

	public void SelectFountain(){
		HazardManager.instance.SelectHazard(fountain);
	}
}
