﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dishspawner : MonoBehaviour {

    [SerializeField]
    private GameObject Dish;


    void OnEnable()
    {
        Instantiate(Dish);
        Dish.transform.position = GetComponent<Transform>().position;
        
    }


}
