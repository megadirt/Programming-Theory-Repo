using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HealthCount
{
    public static int AddHealth(int currentHealth, int additionalHealth)
    {
        return currentHealth + additionalHealth;
    }

    public static string AddHealth(string strA, string strB) //POLYMORPHISM Method Overloading
    {
        return strA + " " + strB;
    }

    public static int MinusHealth(int currentHealth, int damage)
    {
        return currentHealth - damage;
    }
  
}
