using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour {
	public Transform menu;
	public Transform Player;
	void Update () {
		if(Input.GetKeyDown("escape"))
		{
		Pause();
		}
	}

	void Pause()
	{
		if(menu.gameObject.activeInHierarchy == false)
		{
			menu.gameObject.SetActive(true);
			Time.timeScale=0;
		}
		else
		{
			menu.gameObject.SetActive(false);
			Time.timeScale=1;
			//Off Player
		}
	}

}
