using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    

  

    public void GameOver()
    {
        isGameOver = true;
    }
}



/// REPLACE PRIMITIVE SHAPES WITH ASSETS
/// ADD MUSIC AND SOUND EFFECTS AND PARTICLE EFFECTS
/// ADD MENU SCREEN UI WITH CHOICE BETWEEN MOUSE (FASTER) OR RAT (MORE HEALTH, LESS KNOCKBACK)
/// ADD UI FOR FASTEST TIME(HIGH SCORE), AND TIMER(SCORE)
/// ADD "ENTER INITIALS" PLAYER INPUT AT GAME OVER
/// ADD TIMER
/// ADD GAME OVER AND RESTART BUTTON

