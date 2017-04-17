using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSlow : MonoBehaviour {


    public float timer=0f;
    public bool isSlow = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.Instance.speed = GameController.Instance.speed -10 ;
        isSlow = true;
    }
    private void Update()
    {
        if(isSlow==true)
        {
            StartCoroutine(Example());
            GameController.Instance.speed = 50f;
            isSlow = false;
        }
    }
    IEnumerator Example()
    {
       
        yield return new WaitForSeconds(5);
      
    }
}
