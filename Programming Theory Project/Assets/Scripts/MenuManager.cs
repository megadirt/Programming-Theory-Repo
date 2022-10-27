using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public TMP_InputField nameInput;
    public string playerName;
    public static MenuManager Instance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePlayerName()
    {
        playerName = nameInput.text;
    }

    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }
}
