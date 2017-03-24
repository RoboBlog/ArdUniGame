using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
			
	public GameObject MenuCanvas;
	public GameObject OptionCanvas;
	void start(){
	MenuCanvas.SetActive(true);
	OptionCanvas.SetActive(false);
	}
	public void StartGame()
	{
		Application.LoadLevel(1);
	}
	public void Option()
	{
		 MenuCanvas.SetActive(false);
		  OptionCanvas.SetActive(true);
	}
	public void Quit()
	{
		Application.Quit();
	}
	public void Return()
	{
		  MenuCanvas.SetActive(true);
		  OptionCanvas.SetActive(false);
	}
	public void info()
	{
		Application.OpenURL("http://roboblog.eu/2017/03/14/ardunigame/");
	}

}
