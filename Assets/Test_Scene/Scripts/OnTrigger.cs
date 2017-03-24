using UnityEngine;

public class OnTrigger : MonoBehaviour {
	public int JumpAmount=2;
    void OnTriggerExit2D(Collider2D other)
   {
	   if(other.CompareTag("Player"))
	   {
		    Controller_Keyboard.a--;
	   }
   }
   
	void OnTriggerStay2D(Collider2D other)
	{
	 if(other.CompareTag("Player"))
	   {
		   Controller_Keyboard.a=JumpAmount;	   
	   }
	}


}