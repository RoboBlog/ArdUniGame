using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu_UI : MonoBehaviour {
	public Transform menu;
	public void Resume()
	{
			menu.gameObject.SetActive(false);
			Time.timeScale=1;
	}

	public void SaveExit()
	{
	Application.LoadLevel(0);//Load Menu
	}
}
