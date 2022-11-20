using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Player playerID;
    Rigidbody rb;
    public float speed;
    private GameManager gameManager;
   
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        playerID = gameObject.GetComponent<Player>();
        rb = GetComponent<Rigidbody>();
        speed = playerID.speed;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

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
        if (!gameManager.isGameOver)
        {
            rb.velocity = direction * speed;
        }
    }
}
