using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;



public class PlayAd : MonoBehaviour {
    private void Awake()
    {
        Advertisement.Initialize("1411971", true);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            IAPModel.Instance.score += 100;
            IAPModel.Instance.ShowScore();
        }
    }


}
