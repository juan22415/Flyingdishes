using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabdish : MonoBehaviour {


    public piler pile;
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
            Destroy(other.gameObject);
            pile.IncreasePile();
            
        }
       
    } 
}
