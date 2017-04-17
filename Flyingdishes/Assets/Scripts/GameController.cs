using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : Singleton<GameController>
{
    public float speed = 50f;
    bool paused;



    public virtual void PlayerLostLife()
    {
        // deal with player life lost (update U.I. etc.)
    }
    public  void SlowSpeed()
    {
        speed -= 40f;
    }
    public void normalSpeed()
    {
        speed = 50f;
    }
    public virtual void SpawnPlayer()
    {
        // the player needs to be spawned
    }
    public virtual void Respawn()
    {
        // the player is respawning
    }
    public virtual void StartGame()
    {
        // do start game functions
    }
  
    public virtual void RestartGameButtonPressed()
    {
        // deal with restart button (default behavior re-loads the
        // currently loaded scene)
        SceneManager.LoadScene(1);
    }
    public bool Paused
    {
        get
        {
            // get paused
            return paused;
        }
        set
        {
            // set paused
            paused = value;
            if (paused)
            {
                // pause time
                Time.timeScale = 0f;
            }
            else
            {
                // unpause Unity
                Time.timeScale = 1f;
            }
        }
    }
}

    
