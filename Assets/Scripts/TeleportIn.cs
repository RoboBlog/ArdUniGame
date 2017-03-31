using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportIn : MonoBehaviour {
	public Vector2 myvalue;
	private float timer = 0;
	public Transform tipGui;
	public float tiptimer = 3;
	void Update(){
	
	
	}
		void displayTipMessage()
	{
		
		tipGui.gameObject.SetActive(true);
	}
	void OnTriggerStay2D(Collider2D other)
	{
		 if(other.CompareTag("Player")){
			displayTipMessage();
		myvalue = GameObject.Find("TeleportOut").transform.position;
		
		 if(Input.GetKeyDown("e")){
		 
			Controller_Keyboard.rigi.transform.position = myvalue;
			 }
			
		 //Add later Teleport On Click
		}
	}
	 void OnTriggerExit2D(Collider2D other)
			 {
				 tipGui.gameObject.SetActive(false);
			 }

}
