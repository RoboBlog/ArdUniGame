using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

void OnTriggerStay2D(Collider2D other)
{
	if(Input.GetKey("w"))
		{

			Controller_Keyboard.rigi.velocity = new Vector2(0,2);
		}
}
}
