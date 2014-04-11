using UnityEngine;
using System.Collections;

public class aarowaxe2 : MonoBehaviour
{
	public float speed = 20f;				// The speed the axe or arrow.
	public Rigidbody2D projectile;
	public float timer = 0; 					//timer default 
	public Transform player;
	public Transform self;
	private PlayerControltest3d playerCtrl;		// Reference to the PlayerControl script.
	//private Animator anim;					// Reference to the Animator component.


	void Awake()
	{
		// Setting up the references.
		//anim = transform.root.gameObject.GetComponent<Animator>();
		playerCtrl = transform.root.GetComponent<PlayerControltest3d>();
	}


	void Update ()
	{
		Raycasting ();

		if(player.localPosition.x > self.localPosition.x ){
			transform.localEulerAngles = new Vector3(0,90,0);
		}else{
			transform.localEulerAngles = new Vector3(0,-90,0);
		}
	}

	void Raycasting () {
		if (player) {
			float dist = Vector3.Distance(player.position, transform.position);
			print("Distance to archer: " + dist);
			timer += Time.deltaTime;
			if (dist < 10  && timer > 5){
				Behaviors ();
			
			timer = 0;
			}
		}
	}

	void Behaviors () {

		if(player.localPosition.x > self.localPosition.x ){

			//if(playerCtrl.facingRight)
			//{
				// ... instantiate the rocket facing right and set it's velocity to the right.
				Rigidbody2D projectileInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				projectileInstance.velocity = new Vector2(speed, 0);

			//transform.localEulerAngles = new Vector3(0,90,0);
			}
			else
			{
				// Otherwise instantiate the rocket facing left and set it's velocity to the left.	
			Rigidbody2D projectileInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
			projectileInstance.velocity = new Vector2(-speed, 0);

			//transform.localEulerAngles = new Vector3(0,-90,0);
		
			}
		}


}
