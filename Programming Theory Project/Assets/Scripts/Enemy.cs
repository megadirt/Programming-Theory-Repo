using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Enemy : Animal // Inheritance
{
    public static int enemyCount = 0;
    // protected Player player;
    public int damage;
     public Transform player;
    public Player playerScript;


    public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerScript = player.gameObject.GetComponent<Player>();
    }

    public  Enemy()
    {
        enemyCount++;
        Health = 0;
        damage = 0;
        speed = 5;
        
    }

    public abstract void Attack();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Attack();
            
            
        }
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

}
