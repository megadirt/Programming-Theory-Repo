using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Player playerID;
    Rigidbody rb;
    public float speed;
   
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        playerID = gameObject.GetComponent<Player>();
        rb = GetComponent<Rigidbody>();
        speed = playerID.speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }
}
