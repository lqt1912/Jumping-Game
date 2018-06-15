using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour {
    public ManagerLevel level;

	// Use this for initialization
	void Start () {
        level = FindObjectOfType<ManagerLevel>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "player")
        {
            Application.LoadLevel("exitScene");
        }
    }
}
