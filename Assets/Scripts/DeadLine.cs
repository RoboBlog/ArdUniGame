using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour {



    void OnTriggerEnter2D(Collider2D other)
   {
	   if(other.CompareTag("Player"))
	   {
		    Player.health=0;
	   }
   }
}
