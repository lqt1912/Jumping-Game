using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl : MonoBehaviour {

    public bool MoveRight=true;
    // Use this for initialization
    public Transform wallCheck;
    public LayerMask WhatIsWall;
    public float WallRadius;
     bool Walled;
    private bool notAtEg;
    public Transform egCheck;
    void FixedUpdate()
    {
        Walled = Physics2D.OverlapCircle(wallCheck.position, WallRadius, WhatIsWall);
        notAtEg = Physics2D.OverlapCircle(egCheck.position, WallRadius, WhatIsWall);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Walled||!notAtEg)
        {
            MoveRight = !MoveRight;
        }


        if (!MoveRight)
        {
            transform.localScale = new Vector3(8f, 8f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-6, 0);
        }

        else
        {
            transform.localScale = new Vector3(-8f, 8f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(6, 0);
        }

    }
    
}
