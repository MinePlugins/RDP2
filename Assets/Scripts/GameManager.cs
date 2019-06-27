using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public StartGameScript StartGame;

    public bool play;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play == true)
        {
            StartGame.StartFunction();
            AlreadyPlayed();
            

        }

    }

    public static bool enigme1alreadyplayed = false;
    public static bool enigme2alreadyplayed = false;
    public static bool enigme3alreadyplayed = false;

    public void AlreadyPlayed()
    {
        if(enigme1alreadyplayed == true)
        {
            SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
        }
        if (enigme2alreadyplayed == true)
        {
            SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
        }
        if (enigme3alreadyplayed == true)
        {
            SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
        }
    }


    
}
