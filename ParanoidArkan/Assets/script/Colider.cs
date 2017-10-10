using UnityEngine;
using System.Collections;

public class Colider : MonoBehaviour {

	public lvlMng levelMng;


	void OnTriggerEnter2D(Collider2D trigger){
		print("something");
		levelMng.Load("winer");


	}

	void OnCollisionEnter2D(Collision2D collision){

		print ("something2");
	}

}
