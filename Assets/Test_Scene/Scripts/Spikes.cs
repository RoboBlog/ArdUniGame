using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spikes : MonoBehaviour {

	public int Amount=10;
	void OnTriggerEnter2D(Collider2D other)
	{
		 if(other.CompareTag("Player"))
		 {
			 Player.health-=Amount;
		 }
			
	}
		
			
}
			

	
 


