using UnityEngine;
using System.Collections;

public class trigger1 : MonoBehaviour
{
	public Transform platform;
	public Transform target;
	public float smooth = 0.5f;

	bool move=false;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
		if(move == true)
			platform.transform.position = Vector3.Lerp (platform.transform.position, target.position, Time.deltaTime * smooth);
		}

	void OnCollisionEnter2D (Collision2D col) 
	{
		
		
		//if(col.tag == "Player")
		if(col.gameObject.tag =="Projectile")
		{
			move=true;
			//GameObject.Instance(, the desired position, Quaternion.Identity)
			
		}
	}
}

