using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilPlayer : MonoBehaviour {

    // Use this for initialization
    public ManagerLevel level;

	void Start () {
        level = FindObjectOfType<ManagerLevel>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {
            //level.currCheckPoint = gameObject;
            level.Crash();
        }
    }
}
