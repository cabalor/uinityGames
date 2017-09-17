using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextContrl : MonoBehaviour {
	
	public Text text;
	private enum States {
		cell, mirror, sheets, lock_0, corridor, window, bed, lock_1, interroom, corridor_1, room_1, 
		bathroom, stairs_1, closet, lock_3, stairs_2, freedom
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {

		if (myState == States.cell) 			{ Cell ();} 
		else if (myState == States.sheets)	 	{Sheet ();} 
		else if (myState == States.mirror) 		{Mirror ();} 
		else if (myState == States.lock_0)		{cellLock ();} 
		else if (myState == States.corridor)	{corri ();} 
		else if (myState == States.bed) 		{bed ();} 
		else if (myState == States.window) 		{window ();} 
		else if (myState == States.lock_1) 		{lock_1 ();} 
		else if (myState == States.interroom) 	{interroom ();} 
		else if (myState == States.corridor_1) 	{corridor_1();}
		else if (myState == States.room_1) 		{room_1();} 
		else if (myState == States.bathroom) 	{bathroom();}
		else if (myState == States.stairs_1) 	{stairs1();
		}
	}

	#region State
	void Cell(){
		text.text = "Halo Halo our story begins where we have left it." + "It was bla bla bla bla, bedzie nakurwaianie you " +
			"motherfuckers, said Boris blejder "+" He locked you up in a prison. "+" Musis się wydostać. W celi sa "+
				"Sheets, mirror and a lock. \n\n" + "press S for sheets, M for mirror or L for lock";
		if (Input.GetKeyDown (KeyCode.S)) { myState = States.sheets; } 
		else if (Input.GetKeyDown (KeyCode.M)) { myState = States.mirror; } 
		else if (Input.GetKeyDown (KeyCode.L)) { myState = States.lock_0; }
	}

	void Sheet(){
		text.text = "That was a rough night. Sheet is red. You think this is blood. Maybe blejder got you. Who knows?\n\n" +
			"Nacisnij R to return to cell";
		if (Input.GetKeyDown (KeyCode.R)) {myState=States.cell;}
	}

	void Mirror(){
		text.text = "Dirty mirror. you look uglier than usual.\n\n" +
			"Nacisnij R to return to cell";
		if (Input.GetKeyDown (KeyCode.R)) {myState=States.cell;}
	}

	void cellLock(){
		text.text = "you come closer to a cell door and you spot a lock. fortunately you have a lockpick\n\n" +
			"Nacisnij R to return to cell or push P for pick the lock";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.cell;} 
		else if (Input.GetKeyDown (KeyCode.P)) {myState = States.corridor;}
	}
	void corri(){
			text.text = "after you picked the lock, the door stands open and you are in corridor"+
			"you have to find out how to get out from this creepy bulding\n\n" + "press W for window, B for bed or L for lock";
		if (Input.GetKeyDown (KeyCode.B)) {myState=States.bed;}
		else if (Input.GetKeyDown (KeyCode.W)) {myState=States.window;}
		else if (Input.GetKeyDown (KeyCode.L)) {myState=States.lock_1;}

	}
	void bed(){
		text.text = "you se a bed its rather a socialistic one, and it has engraved Boris\n\n" + "press R to retunr to corridor";
		if (Input.GetKeyDown (KeyCode.R)) { myState=States.interroom;}
	}

	void window(){
		text.text = "you see a window, maybe you can try to get out through it, but you cant, you are to big\n\n" + "press R to retunr to corridor, press";
		if (Input.GetKeyDown (KeyCode.R)) { myState=States.corridor;}
	}
	void lock_1(){
		text.text = "you come closer to a cell door and you spot a lock. fortunately you have another lockpick\n\n" +
			"Nacisnij R to return to cell or push P for pick the lock";
		if (Input.GetKeyDown (KeyCode.R)) { myState = States.corridor;} 
		else if (Input.GetKeyDown (KeyCode.P)) { myState = States.interroom;}
	}

	void interroom(){
		text.text = "you are in interroom. what the hell is interrom? you can either go back or try to push out the door in fron of you\n\n" +
			"Nacisnij R to return to cell or push P for push the door";
	  if (Input.GetKeyDown (KeyCode.R)) {myState = States.lock_1;} 
		else if (Input.GetKeyDown (KeyCode.P)) {myState = States.corridor_1;}
}
	void corridor_1(){
		text.text = "you managed to open the door and now you are free. World of brois blejder stands open for you. who knows" +
			"maybe you meet a gypsy who has w dag, but now you are in a corridor\n\n" + "press R to go to room, press b to go to bathroom ";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.room_1;}
		if (Input.GetKeyDown (KeyCode.B)) {myState = States.bathroom;}
	}

	void bathroom(){
		text.text = "just a dirty bathroom with boris blejder painting on the wall\n\n" + "press R to return to corridor";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_1;}
	}

	void room_1(){
		text.text = "nothing in this room but you see door to stairs\n\n" +"press R to return to corridor, press s to go to staris";
		if (Input.GetKeyDown (KeyCode.S)) {myState = States.stairs_1;}
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_1;}
	}

	void stairs1(){
		text.text = "you are on the stairs to room\n\n" +"press R to return to room, press c to go to closet, l to go to lock";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.room_1;}
	}



	#endregion
}
