using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDie : MonoBehaviour {
	private Rigidbody2D reg;
	public AudioClip audio2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Kill") {
			Destroy (gameObject);
			collectCoins.Coins = 0;
			AudioSource.PlayClipAtPoint(audio2,transform.position);
			GameObject go = new GameObject ("NextLevel");
			NextLevel script = go.AddComponent<NextLevel> ();
			script.LevelName = Application.loadedLevelName;
		}
	}
}
