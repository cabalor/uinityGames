using UnityEngine;
using System.Collections;

public class Colider : MonoBehaviour {

	private lvlMng levelMng;

	void Start(){
		levelMng = GameObject.FindObjectOfType<lvlMng>();

	}
	
	void OnTriggerEnter2D(Collider2D trigger){
		levelMng.Load("loose");

	}

	void OnCollisionEnter2D(Collision2D collision){
		print ("something2");
	}

}
