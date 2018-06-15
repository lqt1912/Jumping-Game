using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    // Use this for initialization
    public ManagerLevel level;

	void Start () {
        level = FindObjectOfType<ManagerLevel>();
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {
            level.currCheckPoint = gameObject;
            Debug.Log("Crash! 2nd at " + transform.position);
        }
    }

}
