using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabdish : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "dish")
        {
            ScoreManager.Instance.score = ScoreManager.Instance.score+10;
            Destroy(other.gameObject);
            
        }
       
    } 
}
