﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransit : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToGame()
    {
        SceneManager.LoadScene("Game");    //according to name of scene
    }

    public void ToOptions()
    {

    }

    public void ToHighscore()
    {

    }
}
