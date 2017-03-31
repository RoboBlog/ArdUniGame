using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSetting : MonoBehaviour {

public int ResX;
        public int ResY;
		      public bool Fullscreen;
			   private bool showOptions = false;

	public Transform menu;
	public Transform VideoSettingsUI;
	public void high()
	{
             
             //1080p
                                Screen.SetResolution(1920, 1080, Fullscreen);
                                ResX = 1920;
                                ResY = 1080;
								Debug.Log ("1080p");
                        
          }
		  public void medium()
		  {
			  //720p
                                Screen.SetResolution(1280, 720, Fullscreen);
                                ResX = 1280;
                                ResY = 720;
                                Debug.Log ("720p");
                       
		  }
		  public void low()
		  {
			   //480p
                                Screen.SetResolution(640, 480, Fullscreen);
                                ResX = 640;
                                ResY = 480;
                                Debug.Log ("480p");
		  }
		  public void back()
		  {
			menu.gameObject.SetActive(true);
			 VideoSettingsUI.gameObject.SetActive(false);
		  }
}
