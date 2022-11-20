using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Animal
{

  
    public int keys = 0;
    private Exit exit;
    private GameManager gameManager;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        Health = 5;
        exit = GameObject.Find("Exit").GetComponent<Exit>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {


        CheckKeysInLevel();

        
    }

    public void TakeDamage(int enemyDamage)
    {
        Health = Health - enemyDamage;
        if(Health == 0)
        {
            gameManager.GameOver();
        }
    }

    public void AddKeys(int intA)
    {
        keys += intA;
    }

   public void CheckKeysInLevel()
    {
        if(GameObject.FindGameObjectsWithTag("Key").Length == 0)
        {
            exit.openExit();
        }
        else
        {
            int keyCount = GameObject.FindGameObjectsWithTag("Key").Length;
            Debug.Log(keyCount);
        }
    }
}
