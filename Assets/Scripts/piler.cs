using UnityEngine;

public class piler : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pile;
    private float position = 0.1f;
    public int current;

    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;


    private void Awake()
    {
        source = GetComponent<AudioSource>();

    }
    public void IncreasePile()
    {
        if (current == 4)
        {
            float vol = UnityEngine.Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
            for (int i = 0; i < pile.Length; i++)
            {
                pile[i].SetActive(false);

                current = 0;
            }

            Manager.Instance.LoseLifes(1);
            return;
        }
        pile[current].SetActive(true);
        current++;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LavaPlatos")
        {
            for (int i = 0; i < pile.Length; i++)
            {
                pile[i].SetActive(false);
                Manager.Instance.AddScore(10 * current); //.Score = ScoreManager.Instance.Score + 10 * current;
                current = 0;
            }
        }
    }
}
