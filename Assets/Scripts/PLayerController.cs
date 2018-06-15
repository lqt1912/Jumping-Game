using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PLayerController : MonoBehaviour {

    // Use this for initialization
    public float moveSpeed;
    public float jumpHeight;
    

    public Transform groundCheck;
    public LayerMask WhatIsGround;
    public float GroundRadius;
    public bool Grounded = true;
    public bool DoubleJumped;
    public Animator anim;
    void Start() {
        anim = GetComponent<Animator>();
    }
    
    void FixedUpdate()
    {
        Grounded = Physics2D.OverlapCircle(groundCheck.position, GroundRadius, WhatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("chuyendong", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        anim.SetBool("Grounded", Grounded);
        if(Grounded)
        {
            DoubleJumped = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)&& Grounded)
         {
            jump();
        }
        if (( Input.GetKeyDown(KeyCode.UpArrow))&&! Grounded&&!DoubleJumped)
        {
            jump();
            DoubleJumped = true;
        }
        //GetComponent<Rigidbody2D>().velocity.y
        if (Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.LeftArrow))
        {
             GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
            
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
            
        }
        
    }
    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.y,jumpHeight);
    }
    public void MoveUp()
    {
        if (Grounded)
            DoubleJumped = false;
        if(Grounded)
        {
            jump();
        }
        if(!Grounded&&!DoubleJumped)
        {
            jump();
            DoubleJumped = true;
        }
        
    }
    public void MoveRight()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
    }
    public void MoveLeft()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
    }
    public void ExitBtn()
    {
        Application.LoadLevel("StartScene");
    }
    public void Reset()
    {
        ScoreManager.score = 0;
        Application.LoadLevel("PlayingScene");
    }
    public void ExitBtn2()
    {
        Application.LoadLevel("exitScene");
    }
}
