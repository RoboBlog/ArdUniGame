using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour {

	public int Amount=10;
	void OnTriggerEnter2D(Collider2D other)
	{
		 if(other.CompareTag("Player"))
		 {
			 Player.health+=10;
			 Destroy(gameObject);
		 }
			
	}
}
