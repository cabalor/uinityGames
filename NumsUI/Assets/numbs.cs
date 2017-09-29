using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class numbs : MonoBehaviour {

	int min;
	int max;
	int guess;
	public int maxShoots = 10;

	public Text text;


	void Start () {
		StartGame ();
	}
	
	void StartGame(){
		min = 1;
		max = 1000;
		nextGuess ();
		max = max + 1;
		
	}
	
	void nextGuess(){
		//guess = (max + min)/2; //binary chop
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxShoots = maxShoots - 1;
		if (maxShoots <= 0) {
			Application.LoadLevel("winer");
		}
	}


	public void GuessHigh(){
		min = guess;
		nextGuess ();
	}

	public void GuessLow(){
		max = guess;
		nextGuess();
	}



}

