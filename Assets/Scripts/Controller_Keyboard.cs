using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller_Keyboard : MonoBehaviour {
	public GameObject bulletPrefab;
    public Transform bulletSpawn;
	public static Rigidbody2D rigi;
	//public Rigidbody2D bullet1;
	public float Speed=20.0f;
	public float JumpSpeed=15000.0f;
	public static int a=0;
	public static int rotation=1;
	
	void Start () {
		rigi = GetComponent<Rigidbody2D>();
		//bullet1 = GetComponent<Rigidbody2D>();

	}
	

	void Update () {
			
		if(Input.GetKey("d"))
		{
			if(Input.GetKeyDown("d")) rigi.rotation=(0);//fix it later
				rigi.velocity = new Vector2(Time.deltaTime*Speed*10, rigi.velocity.y);
		
				rotation=1;
				
		}
		
		if(Input.GetKey("a"))
		{
			if(Input.GetKeyDown("a"))rigi.rotation=(180);//fix it later
			rigi.velocity = new Vector2(-Time.deltaTime*Speed*10, rigi.velocity.y);
			rotation=-1;
	
		}


	if (Input.GetKeyDown("space"))
		{
		if(a >= 1)
		rigi.AddForce(Vector2.up * JumpSpeed * Time.deltaTime);
		a--;
        }
		
        if (Input.GetKeyDown("return")) 
        {
			Debug.Log("test");
            Fire();
			
        }
	  

		
	}
	  void Fire()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(Time.deltaTime*Speed*100*rotation, rigi.velocity.y);
		
        Destroy(bullet, 2.0f);        
    }

}
