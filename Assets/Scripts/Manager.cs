using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public static Manager Instance { get; private set; }

    public Image dish1;
    public Image dish2;
    public Image dish3;

    public Text scoreText;

    public int score = 0;
    public int lifes = 3;
    public float speed = 3;
    public int multiplicador = 1;

    void Awake()
    {


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
    private void Start()
    {

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
        if (lifes == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void AddScore(int value)
    {
        score += value * multiplicador;

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
    IEnumerator Example()
    {
        yield return new WaitForSeconds(7);
        speed = 3;
    }
    public void EfectoCafe()
    {
        speed = 4;
        StartCoroutine(Example());
    }
    public void LoseLifes(int value)
    {
        if (lifes == 3)
        {

            dish1.enabled = false;


        }
        if (lifes == 2)
        {
            dish2.enabled = false;

        }
        if (lifes == 1)
        {
            dish3.enabled = false;

        }
        lifes -= value;


    }
}