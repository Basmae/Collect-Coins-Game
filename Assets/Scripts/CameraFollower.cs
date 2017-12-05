﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {
	public GameObject target;
	private Transform t;
	// Use this for initialization
	void Start () {
		t = target.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(t)
		transform.position = new Vector3 (t.position.x, t.position.y, transform.position.z);
	}
}
