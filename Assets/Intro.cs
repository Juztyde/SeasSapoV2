using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public void Continuar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SeleccionNiveles");
    }    

    
    public void Quit()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
