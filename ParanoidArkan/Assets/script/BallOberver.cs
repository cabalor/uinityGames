using UnityEngine;
using System.Collections;

public class BallOberver : MonoBehaviour {

	public pad pad;
	private bool started = false;
	private Vector3 padToBall;
	// Use this for initialization
	void Start () {
	
		padToBall = this.transform.position - pad.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if (started == false) {
			this.transform.position = pad.transform.position + padToBall;
		}
		if(Input.GetMouseButtonDown(0)){
			print ("mouse clicked");
			this.rigidbody2D.velocity = new Vector2(2f , 15f);
			started = true;
		}

	}
}
