using UnityEngine;

public class piler : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pile;
    private float position = 0.1f;
    public int current;

    public void IncreasePile()
    {
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
