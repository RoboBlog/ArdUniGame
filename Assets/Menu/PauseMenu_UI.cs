using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu_UI : MonoBehaviour {
	public Transform menu;
	public Transform VideoSettingsUI;
	void setup(){
		VideoSettingsUI.gameObject.SetActive(true);
	}
	public void Resume()
	{
			menu.gameObject.SetActive(false);
			Time.timeScale=1;
	}

	public void SaveExit()
	{
	PlayerPrefs.SetInt("Money", 10);
	}
	public void VideoSettings()
	{
		menu.gameObject.SetActive(false);
		VideoSettingsUI.gameObject.SetActive(true);

	}

}
