using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virtual : MonoBehaviour {

    // Use this for initialization\
     Virtual.BtnType bt;
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.4f, 0.4f);
    }
    void Start () {
		
	}
    public void OnMouseUp()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.y, 10);
    }

    // Update is called once per frame
    void Update () {
        if(bt==BtnType.up)
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.y, 10);
    }
    public enum BtnType
    {
        up
    }
}
