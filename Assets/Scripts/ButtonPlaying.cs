using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlaying : MonoBehaviour {

    // Use this for initialization
    public ButtonPlaying.BtnType btn;
    public float moveSpeed;
    public float jumpHeight;


    public Transform groundCheck;
    public LayerMask WhatIsGround;
    public float GroundRadius;
    public bool Grounded = true;
    public bool DoubleJumped;
    public Animator anim;
    void Start () {
		
	}

    void FixedUpdate()
    {
        Grounded = Physics2D.OverlapCircle(groundCheck.position, GroundRadius, WhatIsGround);
    }
    // Update is called once per frame
    void Update () {
        OnMouseDown();
        OnMouseUp();
		
	}
    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.4f, 0.4f);
    }
    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.6f, 0.6f);

        anim.SetFloat("chuyendong", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        anim.SetBool("Grounded", Grounded);

        if (Grounded)
        {
            DoubleJumped = false;
        }
        if (btn == ButtonPlaying.BtnType.up && Grounded)
            jump();
        if (btn == ButtonPlaying.BtnType.up && !Grounded && !DoubleJumped)
        {
            jump();
            DoubleJumped = true;
        }
        if (btn == ButtonPlaying.BtnType.left)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
        }
        if (btn == ButtonPlaying.BtnType.right)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
        }
    }
    public enum BtnType
    {
        up,
        right,
        left
    }
    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.y, jumpHeight);
    }

    void test()
    {
        
    }
}
