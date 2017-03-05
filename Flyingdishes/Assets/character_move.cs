using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_move : MonoBehaviour {

    private Rigidbody2D char_rigidbody;
    [SerializeField]
    private float speed=50;


    void Start()
    {
        char_rigidbody = GetComponent<Rigidbody2D>();
    }

	void Update () {

        float horizontalmove = Input.GetAxis("Horizontal");
        move(horizontalmove);
		
	}

    private void move(float hmove)
    {   
        char_rigidbody.velocity=new Vector2(hmove * speed, 0);
    }
}
