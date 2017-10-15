using UnityEngine;
using System.Collections;

public class BallOberver : MonoBehaviour {

	public pad pad;

	private Vector3 padToBall;
	// Use this for initialization
	void Start () {
	
		padToBall = this.transform.position - pad.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = pad.transform.position + padToBall;
	}
}
