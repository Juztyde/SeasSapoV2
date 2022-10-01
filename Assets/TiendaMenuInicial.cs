using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiendaMenuInicial : MonoBehaviour
{
    public void Tienda()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Tienda");
    }

    public void MenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuInicial");
    }
}
