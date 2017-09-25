using UnityEngine;
using System.Collections;

public class goBack : MonoBehaviour {

	public void Load(string lvl){
		
		Debug.Log ("lvl loaded " + lvl);
		
		Application.LoadLevel(lvl);
		
	}




}
