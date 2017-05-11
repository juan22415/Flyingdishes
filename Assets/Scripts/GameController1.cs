﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController1 : Singleton<GameController1>
{
    public float speed = 3;
    bool paused;



    public virtual void PlayerLostLife()
    {
        // deal with player life lost (update U.I. etc.)
    }
    public void SlowSpeed()
    {
        if (speed == 0)
        {
            speed = 1;
        }
        else
            speed = speed / 2;
    }
    public void normalSpeed()
    {
        speed = 3;
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

