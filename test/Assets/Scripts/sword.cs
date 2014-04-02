using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour 
{
	void Update (){
		if(Input.GetButtonDown("Swing")) {
		transform.Rotate (0,0,90);
					
	}
	}

	void OnCollisionEnter2D (Collision2D col) 
		{

		//if(col.tag == "Player")
		if(col.gameObject.tag =="Enemy")
		{
			col.gameObject.GetComponent<Enemy>().Hurt();


		}

	}
}
