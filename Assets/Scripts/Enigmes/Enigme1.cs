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
     


    // Start is called before the first frame update
    void Start()
    {

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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
