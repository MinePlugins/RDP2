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

    public bool AlreadyPlayed = false;
    public GameObject Malus;
    public GameObject All;
    public GameObject Finish;

    // Start is called before the first frame update
    void Start()
    {
        if (AlreadyPlayed == true)
        {
            Malus.SetActive(false);
            All.SetActive(false);
            Finish.SetActive(false);
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
        EnigmeManager.Finish(endTime);
        AlreadyPlayed = true;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
