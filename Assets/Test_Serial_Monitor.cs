using System.Collections;
using System.Collections.Generic;
using UnityEngine; 	
using System.IO.Ports;

public class Test : MonoBehaviour {

SerialPort serial = new SerialPort("COM6", 9600);

	void Start () {
		serial.Open();

		
	}

	void Update () {
		  try{
             print (serial.ReadLine());
       		}
        	 catch(System.Exception){
        	 }
	}
}
