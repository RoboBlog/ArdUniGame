using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	private float timer;	
	Text text;
	void Start () {
		text = GetComponent<Text> () ;
	}
	
	void Update () {
		timer += Time.deltaTime;
		int timerint = (int)timer;
		text.text = "Time: " + timerint;

		text.text = "Health: " + Player.health+ timerint;
		}
	}

