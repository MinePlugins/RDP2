using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enigme3 : MonoBehaviour
{
    public GameObject all;
    public TMP_InputField Input;
    private float endTime;


    public bool AlreadyPlayed = false;
    public GameObject Malus;
    public GameObject All;
    public GameObject Finish;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.enigme3alreadyplayed == true)
        {
            Malus.SetActive(false);
            All.SetActive(false);
            Finish.SetActive(false);
            SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Valider()
    {
        if (Input.text == "0")
        {
            all.SetActive(false);
            endTime = EnigmeManager.timercount;
            GameManager.enigme3alreadyplayed = true;
            GameManager.numbEnigme += 1;
            EnigmeManager.Finish(endTime);
        }
        else
        {
            EnigmeManager.AddMalus(100);
        }
    }
}