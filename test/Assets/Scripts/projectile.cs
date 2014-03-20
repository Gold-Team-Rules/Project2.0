using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour 
{
	void Update ()
	{
		transform.Rotate (0,0,180*Time.deltaTime);
	}
	void Start () 
	{
		Destroy (gameObject, 2);
	}
	

	void OnCollisionEnter2D (Collision2D col) 
	{


		//if(col.tag == "Player")
		if(col.gameObject.tag =="Player")
		{
			Destroy(gameObject);


		}

	}
}
