using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuIncial : MonoBehaviour
{
   
    public void Jugar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SeleccionNiveles");
    }

    
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

    

}
