using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Level_Generator : MonoBehaviour {
public GameObject GroundPrefab;
public GameObject DeadLinePrefab;

	void Start () {
	// for(int i=0; i<10; i++)
	// {
	// 	GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
	// 	ground.transform.position = new Vector2(i,1);
	// }


		Vector2 PositionGround = new Vector2(Random.Range(1,4), Random.Range(1,4));
		Vector2 PositionDeadLine = new Vector2(0, -10);


		Instantiate(DeadLinePrefab, PositionDeadLine, Quaternion.identity);
		Instantiate(GroundPrefab, PositionGround, Quaternion.identity); //Instantiatte test ground
	}
	
	void Update () {
		
	}

	void FixedUpdate () {
}
}
