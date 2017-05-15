using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager :MonoBehaviour
{

    public static Manager Instance { get; private set; }

    public Image dish1;
    public Image dish2;
    public Image dish3;
   
    public Text scoreText;
    public Text lifesText;
    public int score=0;
    public int lifes=3;
    public float speed=3;

    void Awake()
    {
        lifesText.text = "" + lifes;
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
    }
    public void SlowSpeed()
    {

        if (speed == 0)
        {
            speed = 1;
        }
        else
            speed = speed / 1.5f;
    }
    public void normalSpeed()
    {
        speed = 3;
    }
   
    private void Update()
    {
        if (lifes==0)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void AddScore(int value)
    {
        score += value;

        scoreText.text = "" + score;
        switch (score)
        {
            case 100:
                Spawnermanager.Instance.maxtime = 3;
                break;
            case 200:
                Spawnermanager.Instance.maxtime = 2.8f;
                break;
            case 300:
                Spawnermanager.Instance.maxtime = 2.7f;
                break;
            case 400:
                Spawnermanager.Instance.maxtime = 2.6f;
                break;
            case 500:
                Spawnermanager.Instance.maxtime = 2.5f;
                break;
            default:
                break;
        }



    }
  
    public void LoseLifes(int value)
    {
        if(lifes==3)
        {
            dish3.enabled = false;
        }
        if(lifes==2)
        {
            dish2.enabled = false;
        }
        lifes -= value;
       
        lifesText.text = "" + lifes;
    }
}