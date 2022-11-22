using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public string playerName;
    public static MenuManager Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
        
    }

    public void Update()
    {
        PlayerName();
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerName()
    {
        playerName = inputField.text;
        GameManager.instance.PlayerDisplay.text = playerName;
    }

}
