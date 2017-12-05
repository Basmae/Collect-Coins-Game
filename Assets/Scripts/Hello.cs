using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hello: MonoBehaviour {
	public float speed=3f;
	public static int Coins=0;
	 Text coinText;
	// Use this for initialization
	void Start () {
		coinText = GetComponent<Text> ();
		coinText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (new Vector3 (speed, 0, transform.position.z) * Time.deltaTime);
		coinText.text+="Score: ";

	}
	/*public void AddCoins ()
	{
		Coins=Coins+1;
		coinText.GetComponent<Text>().text = "Coins: "  + Coins;
		print ("ss");
	}*/
}
