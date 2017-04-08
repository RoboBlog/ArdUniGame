using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour {

	private Vector2 velocity;
	public float smoothTimeX;
	public float smoothTimeY;
	
	public GameObject player;
	void Start () {
		player=GameObject.FindGameObjectWithTag("Player");
		
	}

	void FixedUpdate () {
		// Vector3 playerpos = player.position;
		// playerpos.z = transform.position.z;
        // transform.position = playerpos;


		float posX= Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		float posY= Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);
		transform.position = new Vector3(posX, posY,-10);
	}
}
