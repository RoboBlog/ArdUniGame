﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public static int health = 100;
	public static int money = 0;
	void Start () {
		
	}
	
	void Update () {
		if(health<=0)
		{
			Destroy (gameObject);
			Destroy(this);
		}
	}
}
