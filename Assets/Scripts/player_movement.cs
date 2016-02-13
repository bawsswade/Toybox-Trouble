using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	// params for animations
	public float speed = 10f;
	public float jumpStr;
	public float maxVel = 2;

	// moving the rigid body
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
        jumpStr = 10f;
	}

	// Called once every frame of rigid body
	void FixedUpdate()
	{
        
		float h = Input.GetAxis ("Horizontal");
        float v = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(rb2d.velocity.y < .5f || rb2d.velocity.y > -0.5f)
            v += jumpStr; 
        }
        rb2d.velocity = new Vector2(h * speed, rb2d.velocity.y + v);
	}

    

}
