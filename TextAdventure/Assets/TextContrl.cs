using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextContrl : MonoBehaviour {


	public Text text;



	// Use this for initialization
	void Start () {
	
		text.text = "Hell world";


	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.Space)) {
			text.text = "halo halo";
		}



	}
}
