using UnityEngine;
using System.Collections;

public class aarowaxe : MonoBehaviour
{
	public float speed = 20f;				// The speed the axe or arrow.
	public Rigidbody2D projectile;
	public float timer = 0;
	private PlayerControltest3d playerCtrl;		// Reference to the PlayerControl script.
	//private Animator anim;					// Reference to the Animator component.
	 bool throwingstar = false;
	public walljump throwing;

	void Awake()
	{
		// Setting up the references.
		//anim = transform.root.gameObject.GetComponent<Animator>();
		playerCtrl = transform.root.GetComponent<PlayerControltest3d>();
	}





	void Update ()
	{	
		timer += Time.deltaTime;

		if (throwing.throwing==true) {
			throwingstar=true;
		}


		// If the fire button is pressed...
		if(timer>=1){
			if(throwingstar==true){

		if(Input.GetButtonDown("Fire1"))
		{
				timer=0;
			// ... set the animator Shoot trigger parameter and play the audioclip.
			//anim.SetTrigger("Shoot");
			//audio.Play();

			// If the player is facing right...
			if(playerCtrl.facingRight)
			{
				// ... instantiate the rocket facing right and set it's velocity to the right. 
				Rigidbody2D projectileInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				projectileInstance.velocity = new Vector2(speed, 0);
			}
			else
			{
				// Otherwise instantiate the rocket facing left and set it's velocity to the left.
				Rigidbody2D projectileInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
				projectileInstance.velocity = new Vector2(-speed, 0);
			}
			}
		}
		}
	}
}
