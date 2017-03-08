﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piler : MonoBehaviour {

    
    [SerializeField]
    private GameObject[] pile;
    private float position=0.1f;
    private int current;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "dish")
        {
            pile[current].SetActive(true);
            current++;


        }
        if (other.gameObject.tag == "LavaPlatos")
        {
            for(int i=0;i < pile.Length;i++)
            {
                pile[i].SetActive(false);
                current = 0;
            }
       

        }
    }
}
