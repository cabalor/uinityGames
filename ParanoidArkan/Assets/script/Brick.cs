using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {


	public int maxHp;
	private int hits;


	// Use this for initialization
	void Start () {
		hits = 0;


	}
	
	// Update is called once per frame
	void Update () {
	



	}
	void OnCollisionEnter2D(Collision2D collision){

			hits++;
			print ("something2");

	}


}
