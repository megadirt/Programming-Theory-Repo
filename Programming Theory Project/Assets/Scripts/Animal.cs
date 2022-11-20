using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int health;
    public int Health

    {
        get { return health; } //Encapsulation
        set
        {
            if (value >= 0)
            {
                health = value;
            }

            if(value < 0)
            {
                health = 0;
            }
        }
    }
    public float speed;
    
   
}
