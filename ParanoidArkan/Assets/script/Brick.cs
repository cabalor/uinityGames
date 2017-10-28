using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {


	public int maxHp;
	private int hits;
	private lvlMng Manager;
	
	// Use this for initialization
	void Start () {
		hits = 0;
		Manager = GameObject.FindObjectOfType<lvlMng> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionExit2D(Collision2D collision){

			hits++;
		if (maxHp == hits) {
			Destroy (gameObject);
		}

	}

	void WinTheGame(){
		Manager.LoadNextLvl ();
	}
	
	//TODO remove Winthegame
}
