using UnityEngine;
using System.Collections;

public class MeleeEnemy : MonoBehaviour {
	public Transform sightStart;
	public Transform sightEnd;
	public bool spotted= false;
	public float timer = 1;
	int currentspeed = 4;
	int turn = -1;
	public Transform player;
	public float speed = 2;
	public float swingtimer = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Raycasting ();
		Behaviors ();
		Attacking ();
	}

void Raycasting ()
{
	float dist = Vector3.Distance(player.position, transform.position);
		print("Distance to melee: " + dist);
		if (dist < 10 && Physics2D.Raycast(transform.position,transform.right,10) )

		spotted = true;
		if (dist > 15)
		spotted = false;
	}

void Behaviors ()
{ if (spotted == false) {
		transform.Translate(Vector3.right * currentspeed * Time.deltaTime);
		timer += Time.deltaTime;
		if(timer < 5.5)
		{
				transform.localEulerAngles = new Vector3(0,90,0);
			//transform.RotateAround (transform.position, transform.up, 180f);
			//currentspeed= currentspeed*turn;
			//timer = 1;
		}else if(timer >10){
				transform.localEulerAngles = new Vector3(0,-90,0);
			timer=0;
		}
	}
	if (spotted == true){
		//transform.Translate(new Vector3(speed* Time.deltaTime,0,0)); //this is where we figure what the enemy will do when they player is close enough
			//print("caught");
			float step = currentspeed * Time.deltaTime;
			transform.LookAt(player);
			transform.position = Vector3.MoveTowards(transform.position, player.position, step);

		}
	}
	void Attacking ()
	{ float dist = Vector3.Distance(player.position, transform.position);
		swingtimer += Time.deltaTime;
		if (dist < 2 && spotted == true && swingtimer > 2){
			print ("attack");
		swingtimer = 1;
	}
	}
}