using UnityEngine;
using System.Collections;

public class lvlMng : MonoBehaviour {

	public void Load(string lvl){
		Brick.brickToBreak = 0;
		Application.LoadLevel(lvl);
	}

	public void quit(){
		Application.Quit ();
	}

	public void LoadNextLvl(){
		Brick.brickToBreak = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void LastBrick(){
		if (Brick.brickToBreak <= 0) {
			LoadNextLvl();
		}
	}


}
