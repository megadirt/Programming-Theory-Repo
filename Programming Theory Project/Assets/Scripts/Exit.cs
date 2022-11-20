using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private Player _player;
    [SerializeField]private bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        
        _player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame

    public void openExit()
    {
        isOpen = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && isOpen)
        {
            Debug.Log("You win bitch");
        }
        else if(other.gameObject.tag == "Player" && !isOpen)
        {
            Debug.Log("Don't forget the keys bitch");
        }
    }
}
