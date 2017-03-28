using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public Rigidbody2D rigi;
	
	public GameObject bulletPrefab;
    public Transform bulletSpawn;

	public Rigidbody2D bullet1;
	public static int health = 100;
	public int Damage = 10;
	public int Speed = 10;
	public int Amount = 30;
	public int TouchDamage = 20;
	public int Discance;
	  public float fireRate = 0.5F;
	  public float timer;
  private float nextFire = 0.0F;
	void Start () {
			rigi = GetComponent<Rigidbody2D>();
				bullet1 = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		
		float distance = Vector2.Distance(Controller_Keyboard.rigi.transform.position, rigi.transform.position);
		//Debug.Log(distance);
		//Distance Enemy to the player
		 
		if(distance<10)
		{
			
			Fire();	
			
		}

		if(rigi.position.x<0 && rigi.position.x>=9)
		{
		rigi.velocity = new Vector2(Time.deltaTime*-Speed*10, rigi.velocity.y);
		}
			//shot if distance < 15
			//navmesh
			//follow
			//rotate 
			//look at


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
	  void Fire()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);
		 bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(Time.deltaTime*Speed*100, rigi.velocity.y);
	  
        Destroy(bullet, 2.0f);        
    }
}
