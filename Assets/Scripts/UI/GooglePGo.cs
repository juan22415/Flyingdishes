using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GooglePGo : MonoBehaviour
{
    public AudioClip shootSound;

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void CambiarEscena()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        source.PlayOneShot(shootSound, vol);
        SceneManager.LoadScene(3);
    }
}
