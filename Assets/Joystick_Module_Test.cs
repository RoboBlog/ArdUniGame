using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine; 	
using System.IO.Ports;
//using System.Threading;

public class Joystick_Module_Test : MonoBehaviour {

	SerialPort serial = new SerialPort("COM6", 9600);
	public Rigidbody2D rigi;

	void Start () {

		serial.ReadTimeout = 50;
		serial.Open();
		rigi = GetComponent<Rigidbody2D>();
 	}


	void Update () {

	
 		int result = Convert.ToInt32(serial.ReadLine());
		Debug.Log(result);
		//Thread.Sleep(100);
	
	if(result==0)
	{
	
		//	transform.position = new Vector2(0,0);
		rigi.velocity = new Vector2(2f *1f, rigi.velocity.y);
	}
	else 
	{
		//rigi.velocity = new Vector2(-2f *1f, rigi.velocity.y);
	}
		
	}
}
