using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy: MonoBehaviour {

	public Transform left;
	public Transform right;
	public Rigidbody2D mainbody;
	public bool stop=false;
	public int move=1;
	public float speed=0.1f;
	void Start () {
		mainbody=GetComponentInParent<Rigidbody2D> ();
		
	}	
	
	// Update is called once per frame
	void FixedUpdate () {
	//	Debug.DrawRay(right.position, Vector2.down,Color.red,0.5f);
		RaycastHit2D hitLeft = Physics2D.Raycast (left.position, Vector2.down, 0.5f);
		RaycastHit2D hitRight = Physics2D.Raycast (right.position, Vector2.down, 0.5f);


		mainbody.MovePosition(mainbody.position+Vector2.left*move*speed);
		if(hitLeft.collider == null)
		{
			stop=true;
			move=-1;
		}
			if(hitRight.collider == null)
		{
			stop=true;
			move=1;
		}
	}
}
