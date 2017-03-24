using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour {

	// Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
   {
	   if(other.CompareTag("Player"))
	   {
		    Player.health=0;
	   }
   }
}
