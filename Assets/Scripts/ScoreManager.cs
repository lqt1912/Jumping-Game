﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public static int score;
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (score < 0)
        {
            //score = 0;
            Application.LoadLevel("LoseScene");
        }
        text.text = "" + score;
	}
    public static void addPoint(int p)
    {
        score = score + p;
    }
}
