using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            

        }

    }


    public Text MyScoreTextContent;
    void DisplayScore()
    {
        // MyScoreTextContent.text = "score = " + score.ToString();
    }
}
