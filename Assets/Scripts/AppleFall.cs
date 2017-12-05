using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFall : MonoBehaviour {
	//private float speed=0.00001f;
	private Rigidbody2D reg;
	float x,y;
	// Use this for initialization
	void Start () {
		 x = transform.position.x;
		 y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		//var newy = speed;
		//reg.AddForce (new Vector2 (0, newy));
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "appleDestroy") {
			Destroy (gameObject);
		}
	}
}
