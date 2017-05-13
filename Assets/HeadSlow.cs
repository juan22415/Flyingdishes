using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSlow : MonoBehaviour
{
    ParticleSystem hitParticles;
    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    public float timer = 0f;
    public bool isSlow = false;
    private void Awake()
    {
        hitParticles = GetComponentInChildren<ParticleSystem>();
        source = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dish")

        {
            Debug.Log("me dio");
            hitParticles.Play();
            GameController1.Instance.SlowSpeed();
            isSlow = true;
            float vol = UnityEngine.Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
            Destroy(collision.gameObject);
        }


    }
    private void Update()
    {

        if (isSlow == true)
        {
            StartCoroutine(Example());

            isSlow = false;
        }
    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(7);

        GameController1.Instance.normalSpeed();
    }
}
