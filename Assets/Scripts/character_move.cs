using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character_move : MonoBehaviour
{
    public AudioClip shootSound;
    public AudioClip sonidoCafe;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    private Rigidbody2D char_rigidbody;
    public Animator anim;
    public bool isgrouded;
    public float touchtime = 0.2f;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void Start()
    {
        char_rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isMoving", false);
    }

    void Update()
    {


        if (char_rigidbody.velocity.x > 0)
        {
            anim.SetInteger("movedirection", 1);
        }

        else if (char_rigidbody.velocity.x < 0)
        {
            anim.SetInteger("movedirection", -1);
        }

        else if (char_rigidbody.velocity.x == 0)
        {
            anim.SetBool("isMoving", false);
        }

        if (Input.touchCount == 1)
        {
            anim.SetBool("isMoving", true);
            Touch touch = Input.GetTouch(0);


            if (touch.position.x > Screen.width / 2)
            {

                char_rigidbody.velocity = new Vector2(Manager.Instance.speed, char_rigidbody.velocity.y);
            }
            else if (touch.position.x < Screen.width / 2)
            {

                char_rigidbody.velocity = new Vector2(-Manager.Instance.speed, char_rigidbody.velocity.y);
            }


        }

        else

            char_rigidbody.velocity = Vector2.zero;


    }






    private void move(float hmove)
    {
        char_rigidbody.AddForce(new Vector2(hmove * Manager.Instance.speed, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isgrouded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isgrouded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Manager.Instance.AddScore(100);
            Debug.Log("pickup");
        }

        if (other.gameObject.CompareTag("Cafe"))
        {
            other.gameObject.SetActive(false);
            Manager.Instance.EfectoCafe();
            float vol = UnityEngine.Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(sonidoCafe, vol);
        }
        if (other.gameObject.CompareTag("Multiplicador"))
        {
            other.gameObject.SetActive(false);
            Manager.Instance.multiplicador = 2;
            float vol = UnityEngine.Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
        }
    }

}
