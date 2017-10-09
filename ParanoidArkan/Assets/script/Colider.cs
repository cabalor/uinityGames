using UnityEngine;
using System.Collections;

public class Colider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D trigger){
		print("something");
	}

	void OnCollisionEnter2D(Collision2D collision){

		print ("something2");
	}

}
