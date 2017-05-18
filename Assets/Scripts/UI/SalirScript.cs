using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirScript : MonoBehaviour {
  public  bool paused;

    public void OnClickPause()
    {
       if( paused==true)
        {
            Time.timeScale = 1f;
            paused = false;
        }
       else if(paused==false)
        {
            Time.timeScale = 0f;
            paused = true;
        }
    }
    public void OnClick()
    {

        SceneManager.LoadScene(0);
    }
    public void OnClickSalir()
    {
       
        Application.Quit();
    }
   
}
