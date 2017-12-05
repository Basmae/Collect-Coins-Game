using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collectCoins : MonoBehaviour {
	public AudioClip audio3;
	public static int Coins;
	public GameObject playerScoreUI;
	//private Hello h;

	// Use this for initialization
	void Start () {
		

		playerScoreUI.gameObject.GetComponent<Text> ().text = ("Score: " + Coins);
	}
	
	// Update is called once per frame
	void Update () {
		playerScoreUI.gameObject.GetComponent<Text> ().text = ("Score: " + Coins);
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "player") {
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint (audio3, transform.position);
			Coins +=1;

		}
	}
	/*void AddCoins()
	{
		Coins=Coins+1;
		coinText.text = "Coins: "  + Coins;
		print ("ss");
	}*/
}
