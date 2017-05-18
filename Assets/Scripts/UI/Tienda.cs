using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tienda : MonoBehaviour
{
    public AudioClip shootSound;

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    public void OnClick()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        source.PlayOneShot(shootSound, vol);
        SceneManager.LoadScene(2);
    }
}
