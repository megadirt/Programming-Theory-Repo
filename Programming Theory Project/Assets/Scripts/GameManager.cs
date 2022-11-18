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



