using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionNiveles : MonoBehaviour
{
    public void MenuPrincipal()
    {
       Time.timeScale = 1;
       SceneManager.LoadScene("MenuInicial");
    }
        

    
    public void Quit()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

    public void Intro()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Intro");
    }
    public void PrimerNivel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel 1");
    }

    public void SegundoNivel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel 2");
    }

}
