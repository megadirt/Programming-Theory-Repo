using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Enemy //Inheritance
{
    
    
    // Start is called before the first frame update
    public Cat()
    {
        Health = 5;
        speed = 5;
        damage = 1;
    }

    public override void Attack()  //Polymorphism
    {
        Debug.Log("Cat attacks player");
        player.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);
        
        playerScript.TakeDamage(damage);

        
        
    }
}
