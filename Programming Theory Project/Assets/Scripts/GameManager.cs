using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameOver;
    public string playerName;
    public TextMeshProUGUI PlayerDisplay;
    

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void GameOver()
    {
        isGameOver = true;
    }

    public void Update()
    {
        playerName = PlayerDisplay.text;
    }
}




