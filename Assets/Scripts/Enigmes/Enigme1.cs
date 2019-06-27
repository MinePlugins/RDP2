using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enigme1 : MonoBehaviour
{
    public GameObject all;
    private float endTime;

    public GameObject Malus;
    public GameObject All;
    public GameObject Finish;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.enigme1alreadyplayed == true)
        {
            Malus.SetActive(false);
            All.SetActive(false);
            Finish.SetActive(false);
            SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
        }
    }

    public void False()
    {
        EnigmeManager.AddMalus(100);
    }
    public void True()
    {
        all.SetActive(false);
        endTime = EnigmeManager.timercount;
        GameManager.enigme1alreadyplayed = true;
        EnigmeManager.Finish(endTime);
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
