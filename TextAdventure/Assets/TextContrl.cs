using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextContrl : MonoBehaviour {
	
	public Text text;
	private enum States {cell, mirror, sheets, lock_0, corridor, window, bed, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {

		if (myState == States.cell) {
			stateCell ();
		} else if (myState == States.sheets) {
			stateSheet ();
		} else if (myState == States.mirror) {
			stateMirror ();
		} else if (myState == States.lock_0) {
			cellLock ();
		} else if (myState == States.corridor) {
			corri ();
		} else if (myState == States.bed) {
			bed();
		}
	}

	void stateCell(){
		text.text = "Halo Halo our story begins where we have left it." + "It was bla bla bla bla, bedzie nakurwaianie you " +
			"motherfuckers, said Boris blejder "+" He locked you up in a prison. "+" Musis się wydostać. W celi sa "+
				"Sheets, mirror and a lock. \n\n" + "press S for sheets, M for mirror or L for lock";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		}
	}

	void stateSheet(){
		text.text = "That was a rough night. Sheet is red. You think this is blood. Maybe blejder got you. Who knows?\n\n" +
			"Nacisnij R to return to cell";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState=States.cell;
		}
	}

	void stateMirror(){
		text.text = "Dirty mirror. you look uglier than usual.\n\n" +
			"Nacisnij R to return to cell";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState=States.cell;
		}
	}

	void cellLock(){
		text.text = "you come closer to a cell door and you spot a lock. fortunately you have a lockpick\n\n" +
			"Nacisnij R to return to cell or push P for pick the lock";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.corridor;
		}
	}
	void corri(){
			text.text = "after you picked the lock, the door stands open and you are in corridor"+
			"you have to find out how to get out from this creepy bulding\n\n" + "press W for window, B for bed or L for lock";
		if (Input.GetKeyDown (KeyCode.W)) {
			myState=States.bed;
		}
	}
	void bed(){
		text.text = "you se a bed its rather a socialistic one, and it has engraved Boris\n\n" + "press R to retunr to corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState=States.corridor;
		}
	}

}
