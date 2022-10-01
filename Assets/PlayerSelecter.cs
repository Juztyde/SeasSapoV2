using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelecter : MonoBehaviour
{
    
    

    public enum Player {Sapito, Mascara, PinkMan,Man };
    public Player playerSelected;
    
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersRenderer;

    



    void Start()
    {   
        
           switch (playerSelected)
           {
                case Player.Sapito:
                spriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playersController[0];

                    break;
                case Player.Mascara:
                spriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                    break;
                case Player.PinkMan:
                spriteRenderer.sprite = playersRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
                    break;
                case Player.Man:
                spriteRenderer.sprite = playersRenderer[3];
                animator.runtimeAnimatorController = playersController[3];
                    break;               
                 
            
                default:
                    break;


            }  
               
    }

    
        
            
            

    
    
    
}
