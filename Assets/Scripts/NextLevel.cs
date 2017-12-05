using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {
	public string LevelName="mainSence";
	private bool LockMode = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && !LockMode) {
			Application.LoadLevel (LevelName);
		}
	}
}
