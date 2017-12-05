using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {
	private Rigidbody2D reg;
	public float speed=50f;
	public bool standing;
	public float SpeedSlow = 1f;
	public Vector2 MaxVelocity = new Vector2 (2, 3);
	public Animator animvar;
	public AudioClip audio1;
	public AudioClip audio4;
	// Use this for initialization
	void Start () {
		animvar = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		reg = GetComponent<Rigidbody2D> ();
		float ForceX = Mathf.Abs (reg.velocity.x);
		float ForceY = Mathf.Abs (reg.velocity.y);
		if (ForceY < 0.2f)
			standing = true;
		else
			standing = false;
		var newx = 0f;
		var newy = 0f;
		if(Input.GetKey("right")){
			if (ForceX < MaxVelocity.x) {
				newx = standing ? speed : speed * SpeedSlow;
				animvar.SetInteger ("AnimTrans", 0);

			}
			else
				animvar.SetInteger ("AnimTrans", 1);

			transform.localScale = new Vector3 (1, 1, 1);
	}
		else if(Input.GetKey("left")){
			if (ForceX < MaxVelocity.x) {
				newx = standing ? -speed : -speed * SpeedSlow;
				animvar.SetInteger ("AnimTrans", 1);

			}
			else
				animvar.SetInteger ("AnimTrans", 0);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		else if(Input.GetKey("up")){
			if(ForceY<MaxVelocity.y)
			newy = 5*speed;
			transform.localScale = new Vector3 (1, 1, 1);
			AudioSource.PlayClipAtPoint(audio1,transform.position);
		}
		reg.AddForce (new Vector2 (newx, newy));
		if (transform.position.y <= -6f) {
			Destroy (gameObject);
			collectCoins.Coins = 0;
			AudioSource.PlayClipAtPoint(audio4,transform.position);
			GameObject go = new GameObject ("NextLevel");
			NextLevel script = go.AddComponent<NextLevel> ();
			script.LevelName = Application.loadedLevelName;
		}
}
}
