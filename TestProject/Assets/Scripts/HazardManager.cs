using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardManager : MonoBehaviour {

	public static HazardManager instance;

	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}


	private Hazard hazard;


	public bool CanBuild { get { return hazard != null; } }


	public void SelectHazard (Hazard _hazard)
	{
		hazard = _hazard;
	}

	public GameObject GetHazard ()
	{
		return hazard.hazard;
	}
}
