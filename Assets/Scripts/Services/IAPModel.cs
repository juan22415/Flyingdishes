using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAPModel : MonoBehaviour {
    public int score;
    public Text scoreText;
    public static IAPModel Instance { get; set; }
    private void Awake()
    {
        Instance = this;
        score = PlayerPrefs.GetInt("Scorefile");
    }
    void Start()
    {
        
        scoreText.text = "" + score;

    }

    // Update is called once per frame
    void Update () {
      
    }
    public void ShowScore()
    {
        scoreText.text = "" + score;
    }
    public void Gold50()
    {
        score =score+ 50;
        
        ShowScore();
        IAPManager.Instance.Buy50Gold();
        PlayerPrefs.SetInt("Scorefile",score);

    }
    public void Gold100()
    {
        score =score+ 100;
   
        ShowScore();
        IAPManager.Instance.Buy100Gold();
        PlayerPrefs.SetInt("Scorefile", score);

    }
}
