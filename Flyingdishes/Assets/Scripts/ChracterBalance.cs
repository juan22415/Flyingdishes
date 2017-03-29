using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterBalance : MonoBehaviour {

    public piler leftpile, rightpile;

    public int lefthand, righthand,resut;

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lefthand = leftpile.current;
        righthand = rightpile.current;
        resut = lefthand - righthand;
        if (resut*resut>9)
        {
            Debug.Log("desbalance");
        }
	}
}
