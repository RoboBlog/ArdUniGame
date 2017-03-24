using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller_Keyboard : MonoBehaviour {
	public Rigidbody2D rigi;
	public float Speed=20.0f;
	public float JumpSpeed=15000.0f;
	public static int a=0;
	
	void Start () {
		rigi = GetComponent<Rigidbody2D>();

	}
	

	void Update () {
		if(Input.GetKey("d"))
			rigi.velocity = new Vector2(Time.deltaTime*Speed*10, rigi.velocity.y);
		
		if(Input.GetKey("a"))
			rigi.velocity = new Vector2(Time.deltaTime*-Speed*10, rigi.velocity.y);


	if (Input.GetKeyDown("space"))
		{
		if(a >= 1)
		rigi.AddForce(Vector2.up * JumpSpeed * Time.deltaTime);
		a--;
        }

		
	}
}
