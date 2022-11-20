using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Enemy
{
   public Dog()
    {
        Health = 9;
        speed = 2;
        damage = 4;
    }

    public override void Attack()
    {
        Debug.Log("Dog attacks player");
        player.GetComponent<Rigidbody>().AddForce(Vector3.up * 20, ForceMode.Impulse);
        playerScript.TakeDamage(damage);

    }
}
