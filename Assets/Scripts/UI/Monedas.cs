using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monedas : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Use this for initialization
    private void Awake()
    {
        score = PlayerPrefs.GetInt("Scorefile");
    }
    void Start()
    {

        scoreText.text = "Coins:" + score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
