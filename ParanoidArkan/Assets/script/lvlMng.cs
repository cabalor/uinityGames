using UnityEngine;
using System.Collections;

public class lvlMng : MonoBehaviour {

	public void Load(string lvl){

		Debug.Log ("lvl loaded " + lvl);

		Application.LoadLevel(lvl);

	}

	public void quit(){
		Debug.Log ("game quited");
		Application.Quit ();
	}



}
