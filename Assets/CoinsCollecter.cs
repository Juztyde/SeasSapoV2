using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollecter : MonoBehaviour
{
    
   [SerializeField] private float cantidadPuntos;

   [SerializeField] private Coins coins;

   private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.CompareTag("Player"))
       {
                
           coins.SumarPuntos(cantidadPuntos);
           
       }

    
   }
}
