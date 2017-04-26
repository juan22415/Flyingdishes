using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floormanager : MonoBehaviour
{
    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

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


    public void OnCollisionEnter2D (Collision2D other)
    {

        if (other.gameObject.tag == "dish")
        {
            float vol = UnityEngine.Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
            Destroy(other.gameObject);

            ScoreManager.Instance.LoseLifes(1);
        }

    }
}
