using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour {
	private float timer;
	Text text;
	void Start () {
		text = GetComponent<Text> () ;
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		int timerint = (int)timer;
		text.text = "Time: " + timerint;
		
	}
}
