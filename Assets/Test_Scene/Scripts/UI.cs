using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Health : MonoBehaviour {

	Text text;
	void Start () {
		text = GetComponent<Text> () ;
	}
	
	void Update () {
		

		text.text = "Health: " + Player.health;
		}
	}

