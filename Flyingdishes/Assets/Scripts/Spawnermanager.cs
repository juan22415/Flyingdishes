using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnermanager : MonoBehaviour {

    public GameObject[] spawners;
    private float timer, maxtime = 5;
    private int current;


    private void Update()
    { 
    timer += Time.deltaTime;        
        if (timer > maxtime)
        {
            current = Random.Range(0, spawners.Length);
            Enabler(current);
        }
    }

    void Enabler(int pos)
{
    spawners[pos].SetActive(true);
    timer = 0;
    spawners[pos].SetActive(false);

}


}
