using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportIn : MonoBehaviour {
	public Vector2 myvalue;
	void setup(){
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		myvalue = GameObject.Find("TeleportOut").transform.position;
		 if(other.CompareTag("Player"))
		 {
			Controller_Keyboard.rigi.transform.position = myvalue;
		 }
		 //Add later Teleport On Click
	}
}
