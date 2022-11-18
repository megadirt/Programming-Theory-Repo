using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Animal
{

  
    public int maxFood = 10;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        Health = 5;

}

    // Update is called once per frame
    void Update()
    {
        

        if(Enemy.enemyCount == 0)
        {
            Debug.Log("Safe. For now");
        }

        
    }

    public void TakeDamage(int enemyDamage)
    {
        Health = Health - enemyDamage;
    }

    public void EatCheese()
    {
        Health = HealthCount.AddHealth(health, 2);
        if(Health >= maxFood)
        {
            
            isFull();
        }
    }

    public void isFull()
    {
        Debug.Log(HealthCount.AddHealth("butts", "are lovely"));
        Health = 10;
    }
}
