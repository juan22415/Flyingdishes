using UnityEngine;

public class Grabdish : MonoBehaviour
{

    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    public piler pile;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
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
