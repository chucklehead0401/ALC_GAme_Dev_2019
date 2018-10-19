using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {
    public float MoveSpeed;
    public bool MoveRight;

    public Transform WallCheck;
    public float WallCheckRadius;
    public LayerMask WhatIsWall;
    public bool HittingWall;
    
    
    private bool NotAtEdge;
    public Transform EdgeCheck;



    void Update (){
            NotAtEdge = Physics2D.OverlapCircle (EdgeCheck.position, WallCheckRadius, WhatIsWall);
             HittingWall = Physics2D.OverlapCircle (WallCheck.position, WallCheckRadius, WhatIsWall);
        if (HittingWall || !NotAtEdge){
                MoveRight = !MoveRight;
        }

        if (MoveRight) {
            transform.localScale = new Vector3(-6f,6f,1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        else {
			transform.localScale = new Vector3(6f,6f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
    }

}