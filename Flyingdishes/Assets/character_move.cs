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

        

        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2)
            {


                char_rigidbody.velocity = new Vector2(1 * speed, 0);
            }

            else if (touch.position.x < Screen.width / 2)
            {

                Debug.Log("touchside2");
                char_rigidbody.velocity = new Vector2(-1 * speed, 0);
            }

            if (touch.phase == TouchPhase.Ended)
                char_rigidbody.velocity = Vector2.zero;
        }






        //float horizontalmove = Input.GetAxis("Horizontal");
       // move(horizontalmove);
		
	}

    private void move(float hmove)
    {   
        char_rigidbody.velocity=new Vector2(hmove * speed, 0);
    }

   

}
