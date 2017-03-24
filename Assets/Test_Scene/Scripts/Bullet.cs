using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public int Amount = 10;
	
	void Start () {
	
	}
	
	void Update () {

		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		 if(other.CompareTag("Enemy"))//switch to all tag
		 {
			 Destroy(gameObject);
			 Enemy.health-=Amount;
		 }
	}
}
