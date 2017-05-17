using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAPModel : MonoBehaviour {
    public int score;
    public Text scoreText;
    private void Awake()
    {
        score = PlayerPrefs.GetInt("Scorefile");
    }
    void Start()
    {

        scoreText.text = "" + score;
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void Gold50()
    {
        IAPManager.Instance.Buy50Gold();
        score += 50;
        scoreText.text = "" + score;
    }
    public void Gold100()
    {
        IAPManager.Instance.Buy100Gold();
        score += 100;
        scoreText.text = "" + score;
    }
}
