using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager :  Singleton<ScoreManager>
{
    public Text scoreText;
    public int score = 0;
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
    }
}
