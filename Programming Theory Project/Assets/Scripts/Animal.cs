using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0)
            {
                health = value;
            }
        }
    }
    public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
