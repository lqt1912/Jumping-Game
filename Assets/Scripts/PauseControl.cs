using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour {

    // Use this for initialization
    private bool pause = true;
    public GameObject pauseUI;

	void Start () {
        pauseUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
            pause = !pause;
        if(pause)
        {
            pauseUI.SetActive(true);
        }
        if(!pause)
        {
            pauseUI.SetActive(false);
        }
	}
}

