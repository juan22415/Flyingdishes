﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSlow : MonoBehaviour {


    public float timer=0f;
    public bool isSlow = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dish")
          
        {
            Debug.Log("me dio");
            GameController1.Instance.SlowSpeed();
            isSlow = true;
          
        }

       
    }
    private void Update()
    {
        
        if (isSlow==true)
        {
            StartCoroutine(Example());
            
            isSlow = false;
        }
    }
    IEnumerator Example()
    {
       
        yield return new WaitForSeconds(7);
        Debug.Log("here");
        GameController1.Instance.normalSpeed();
    }
}
