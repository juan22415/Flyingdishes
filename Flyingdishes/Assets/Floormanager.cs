using UnityEngine;

public class Floormanager : MonoBehaviour
{
    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

  
    private void Awake()
    {
        source = GetComponent<AudioSource>();
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
