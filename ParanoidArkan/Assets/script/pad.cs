using UnityEngine;
using System.Collections;

public class pad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 padPos = new Vector3 (3f, this.transform.position.y, 0f);


		float mousePosition = Input.mousePosition.x / Screen.width * 16;

		padPos.x = Mathf.Clamp(mousePosition+3, 3f, 18f);

		print (mousePosition);

		this.transform.position = padPos;


	}
}
