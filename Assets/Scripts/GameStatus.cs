﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroy = 83;

    [SerializeField] int score = 0;
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = gameSpeed;
	}

    public void addToScore()
    {
        score += pointsPerBlockDestroy;
    }
}
