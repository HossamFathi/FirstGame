using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  
    public playerMovement PlayerMovement;
    public GameMonger GameManger;
    private void Start()
    {
       
        GameManger =  GetComponent<GameMonger>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag  ==  "Anemy") //  player die if collision of anemy  only
        {
            PlayerMovement.Rigidbody.useGravity = true; // reuse gravity  for  player
            PlayerMovement.enabled = false; //  player can't move agin
          
            GameManger.Restart(); // go to game manger and over a game
        }
        else if (collision.collider.tag == "gameOver")
        {
             GameManger.playerWon();// go to game manger and over a game  and go to next Level
        }
            


    }
  
}
