using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnermanager : Singleton<Spawnermanager>
{

    public GameObject[] spawners;
    private float timer;
    public float maxtime = 5;
    private int current;


    private void Update()
    { 
        if (current ==4)
        {
            current = 0;
            timer = 0;
            spawners[0].SetActive(false);
            spawners[1].SetActive(false);
            spawners[2].SetActive(false);
            spawners[3].SetActive(false);
            spawners[4].SetActive(false);
         
        }
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
