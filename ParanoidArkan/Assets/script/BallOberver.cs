using UnityEngine;
using System.Collections;

public class BallOberver : MonoBehaviour {

	private pad pad;
	private bool started = false;
	private Vector3 padToBall;
	// Use this for initialization
	void Start () {
		pad = GameObject.FindObjectOfType<pad>();
		padToBall = this.transform.position - pad.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (started == false) {
			this.transform.position = pad.transform.position + padToBall;
		
			if (Input.GetMouseButtonDown (0)) {
				this.rigidbody2D.velocity = new Vector2 (-2f, 10f);
				started = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (started) {
			audio.Play ();
		}
	}
}

