using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaplatosSound : MonoBehaviour
{
    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    // Use this for initialization
    void Start ()
    {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LavaPlatos")
        {
            Debug.Log("hey");
            float vol = UnityEngine.Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
        }
    }
}
