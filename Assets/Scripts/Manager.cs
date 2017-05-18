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
        PlayerPrefs.SetInt("Scorefile", score);
        if (lifes == 0)
        {
            PlayerPrefs.SetInt("Scorefile", score);
            score = PlayerPrefs.GetInt("Scorefile");
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
            case 600:
                Spawnermanager.Instance.maxtime = 2.4f;
                break;
            case 700:
                Spawnermanager.Instance.maxtime = 2.3f;
                break;
            case 800:
                Spawnermanager.Instance.maxtime = 2.2f;
                break;
            case 900:
                Spawnermanager.Instance.maxtime = 2.1f;
                break;
            case 1000:
                Spawnermanager.Instance.maxtime = 2f;
                speed = speed+1;
                break;
            case 1100:
                Spawnermanager.Instance.maxtime = 1.9f;
                break;
            case 1200:
                Spawnermanager.Instance.maxtime = 1.8f;
                break;
            case 1300:
                Spawnermanager.Instance.maxtime = 1.7f;
                speed = speed + 1;
                break;
            case 1400:
                Spawnermanager.Instance.maxtime = 1f;
                speed = speed + 1;
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
        speed = speed+1;
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