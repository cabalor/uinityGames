using UnityEngine;
using System.Collections;

public class Musicplay : MonoBehaviour {

	static Musicplay instance = null;

	Musicplay ()
	{
	}

	void Awake ()
	{
		if (instance != null) {
			Destroy (gameObject);
			print ("one instance");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	void Start ()
	{
	}

	void Update ()
	{
	}


}
