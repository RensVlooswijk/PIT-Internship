using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InworldStart()
    {
        SceneManager.LoadScene("InworldAI");
    }

    public void ChatGPTStart(){
        SceneManager.LoadScene("Demo");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }

}
