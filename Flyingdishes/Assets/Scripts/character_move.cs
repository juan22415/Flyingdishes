﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_move : MonoBehaviour
{

    private Rigidbody2D char_rigidbody;
   
    public bool isgrouded;
    public float touchtime = 0.2f, taptime;

    void Start()
    {
        char_rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {



        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);


            if (touch.position.x > Screen.width / 2)
            {
                char_rigidbody.velocity = new Vector2(GameController1.Instance.speed, char_rigidbody.velocity.y);
            }
            else if (touch.position.x < Screen.width / 2)
            {
                char_rigidbody.velocity = new Vector2(-GameController1.Instance.speed, char_rigidbody.velocity.y);
            }


        }

        else

            char_rigidbody.velocity = Vector2.zero;

}






private void move(float hmove)
{
    char_rigidbody.AddForce(new Vector2(hmove * GameController1.Instance.speed, 0));
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

}
