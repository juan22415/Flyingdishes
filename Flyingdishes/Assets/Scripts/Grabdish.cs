using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabdish : MonoBehaviour {

    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    public piler pile;
	// Use this for initialization
	void Start () {
		
	}
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "dish")
        {
            float vol = UnityEngine.Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
            Destroy(other.gameObject);
            pile.IncreasePile();
            
        }
       
    } 
}
