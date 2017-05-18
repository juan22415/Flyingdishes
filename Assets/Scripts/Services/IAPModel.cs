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
    private void Update()
    {
        PlayerPrefs.SetInt("Scorefile", score);
    }
    void Start()
    {
        
        scoreText.text = "" + score;

    }

    // Update is called once per frame
  
    public void ShowScore()
    {
      
        scoreText.text = "" + score;
    }
    public void Gold50()
    {
      
        IAPManager.Instance.Buy50Gold();

        IAPModel.Instance.score += 50;
        IAPModel.Instance.ShowScore();



    }
    public void Gold100()
    {
        IAPModel.Instance.score += 100;
        IAPModel.Instance.ShowScore();
       
        IAPManager.Instance.Buy100Gold();
     
    
       
    }
}
