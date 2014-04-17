using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour 
{
	public float timer = 0;
	private PlayerControltest3d playerCtrl;


	void Update (){
		timer += Time.deltaTime;

		if(timer>=2){
		if(Input.GetButtonDown("Swing")) {
				//OnCollisionEnter2D (Collision2D);
					
	}
	}
	}

	void Awake()
	{
		playerCtrl = transform.root.GetComponent<PlayerControltest3d>();
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
