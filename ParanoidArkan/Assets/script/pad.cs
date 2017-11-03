using UnityEngine;
using System.Collections;

public class pad : MonoBehaviour {



	public bool testPlay = false;
	private BallOberver ball;


	void Start(){

		ball = GameObject.FindObjectOfType<BallOberver>();
	}



	// Update is called once per frame
	void Update () {
		if (testPlay.Equals (false)) {
			MoveMouse ();
		} else {
			Play();
		}
	}

	void Play(){
		Vector3 padPos = new Vector3 (7f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		padPos.x = Mathf.Clamp(ballPos.x, 3f, 18f);
		this.transform.position = padPos;

	}



	void MoveMouse(){
		Vector3 padPos = new Vector3 (7f, this.transform.position.y, 0f);
		float mousePosition = Input.mousePosition.x / Screen.width * 16;
		padPos.x = Mathf.Clamp(mousePosition+3, 3f, 18f);
		this.transform.position = padPos;

	}


}
