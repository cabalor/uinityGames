using UnityEngine;
using System.Collections;

public class pad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 padPos = new Vector3 (7f, this.transform.position.y, 0f);


		float mousePosition = Input.mousePosition.x / Screen.width * 16;

		padPos.x = Mathf.Clamp(mousePosition+3, 3f, 18f);


		this.transform.position = padPos;


	}
}
