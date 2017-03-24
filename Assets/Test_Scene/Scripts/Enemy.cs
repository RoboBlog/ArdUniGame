using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public Rigidbody2D rigi;
	public static int health = 100;
	public int Damage = 10;
	public int Speed = 10;
	public int Amount = 30;
	public int TouchDamage = 20;
	public int Discance;
	void Start () {
			rigi = GetComponent<Rigidbody2D>();
		
	}
	
	void Update () {
		
		rigi.velocity = new Vector2(Time.deltaTime*-Speed*10, rigi.velocity.y);
		



		if(health<=0)
		{
			Destroy(gameObject);
		}

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		 if(other.CompareTag("Player"))
		 {
			 Player.health-=Amount;
		 }
	}
}
