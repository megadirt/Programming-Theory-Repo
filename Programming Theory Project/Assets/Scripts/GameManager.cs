using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager { get; private set; }

    private int currentScore;
    public int CurrentScore //Encapsulation
    {
        get { return currentScore; }
        set
        {
            if (value >=0)
            {
                currentScore = value;
            }
        }
    }
}


/// CREATE GOAL SPOT FOR PLAYER TO REACH
/// CREATE CHEESE FOR PLAYER TO EAT TO OPEN GOAL
/// REPLACE PRIMITIVE SHAPES WITH ASSETS
/// ADD MUSIC AND SOUND EFFECTS AND PARTICLE EFFECTS
/// ADD MENU SCREEN UI WITH CHOICE BETWEEN MOUSE (FASTER) OR RAT (MORE HEALTH, LESS KNOCKBACK)
/// ADD UI FOR FASTEST TIME(HIGH SCORE), AND TIMER(SCORE)
/// ADD "ENTER INITIALS" PLAYER INPUT AT GAME OVER
/// ADD TIMER
/// ADD GAME OVER AND RESTART BUTTON
/// CREATE LEVEL 1 (COLLECT CHEESE GO TO GOAL)
/// CREATE LEVEL 2 (LEVEL 1 PLUS CAT ENEMY)
