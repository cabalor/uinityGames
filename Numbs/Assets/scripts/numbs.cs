using UnityEngine;
using System.Collections;

public class numbs : MonoBehaviour {

	int min;
	int max;
	int ran;
	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	void StartGame(){
		min = 1;
		max = 1000;
		ran = Random.Range(1,1000);
		
		print ("--------Start Game-------------");
		print ("welcome to numbers");
		print ("pick a number and write it down");
		
		print ("the highest number you can pick is " + max);
		print ("the lowest number you can pick is " + min);
		
		print("is the number higher or lower than "+ran + "?");
		print("up = for higer,down = lower and return = equal");
		max = max + 1;
		
	}
	
	void nextGuess(){
		ran = (max + min)/2; //binary chop
		print ("higher or lower than "+ran);
		print("up = for higer,down = lower and return = equal");
	}
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = ran;
			nextGuess();
			
		}else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = ran;
			nextGuess();
			
		}else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("i won");
			StartGame();
		} 
	}
}

