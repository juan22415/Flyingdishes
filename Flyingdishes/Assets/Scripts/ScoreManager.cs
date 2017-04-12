﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager :  Singleton<ScoreManager>
{
    public Text scoreText;
    public int score = 0;
    public int lifes = 3;
    private void Start()
    {
        
    }
    private void Update()
    {
        scoreText.text = "Score:" + score;
        if(score==100)
        {
            Spawnermanager.Instance.maxtime = 3;
        }
        if(score==200)
        {
            Spawnermanager.Instance.maxtime = 2;
        }
        if(score==300)
        {
            Spawnermanager.Instance.maxtime = 1;
        }

        if (lifes==0)
        {
            SceneManager.LoadScene(0);
        }
    }
}