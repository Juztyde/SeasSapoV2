using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DiamondManager : MonoBehaviour
{   
    
    
    private void Update()
    {
         AllDiamondsCollected();
    }

    
    public void AllDiamondsCollected()
    {
          
         if (transform.childCount==0)
          {
              Debug.Log("No quedan diamantes, Victoria");
              
              Invoke("ChangeScene", 1);

          }
    }

    

    
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    


}


