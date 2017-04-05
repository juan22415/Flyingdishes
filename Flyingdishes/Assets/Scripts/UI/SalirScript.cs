using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirScript : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
    public void OnClickSalir()
    {
        Application.Quit();
    }
}
