using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour {

	private Transform player;
	void Start () {
		player=GameObject.Find("Player").transform;
		
	}

	void Update () {
		Vector3 playerpos = player.position;
		playerpos.z = transform.position.z;
        transform.position = playerpos;
		
	}
}
