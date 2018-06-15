using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnControl : MonoBehaviour {

    // Use this for initialization
    public BtnControl.ButtonType bt;

    private void Start()
    {
    }
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.4f, 0.4f);
        
       
    }
    private void OnMouseUp()
    {
         transform.localScale = new Vector3(0.6f, 0.6f);
          if(bt==BtnControl.ButtonType.btnPlay)
        {
            Application.LoadLevel("PlayingScene");
        }
          if(bt==BtnControl.ButtonType.btnExit)
        {
            Application.Quit();
        }


    }
    
    public enum ButtonType
    {
        btnPlay,
        btnExit,
    }
}

