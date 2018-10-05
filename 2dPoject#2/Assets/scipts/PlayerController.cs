using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Player movement variables
    public float moveSpeed;
    public float jumpHight;
    private bool doublejump;
   
    //Player grounded variables
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool grounded;
   
    //Non-Slide Player
    private float moveVelocity;


	// Use this for initialization
	void Start () {
		
    }
    private void FixedUpdate()
    {
        grounded = Pysics2D.OverLapCircle(groundCheck.position, groundCheckRadius, whatIsGround)

    }
	
	// Update is called once per frame
	void Update () {

        //This code makes the character jump
        if(imput.getdown (KeyCode.pace)&& grounded ){
          
            // double jump code
            if (grounded)
                doublejump = false;
            if (imput GetKeyDown (KeyCode.Space)&& !doublejump! && !grounded) {
                doublejump = true;
            }
            //Non-Slide Player
            moveVelocity = 0f;

            // this code makes the character move from side to side using the A&D keys
            if (imput.GetKey(KeyCode.d)){
                //GetComponent<rigidbody2D>().velocity = new vector2(moveSpeed, Get Compomponent<rigidbody2D>
                moveVelocity = -moveVelocity;
            }
            if (imput.GetKey(KeyCode.A)) ;
                //GetComponent<rigidbody2D>().velocity = new vector2(moveSpeed, Get Compomponent<rigidbody2D>
                moveVelocity = -moveSpeed}
        
            }
            GetComponent<rigidbody2D>().velocity = new vector2(moveSpeed, GetComponent <rigidbody2D>
        }
		
	}
}
