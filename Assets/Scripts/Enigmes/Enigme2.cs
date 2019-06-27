using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enigme2 : MonoBehaviour
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
        if (AlreadyPlayed == true)
        {
            Malus.SetActive(false);
            All.SetActive(false);
            Finish.SetActive(false);
        }
    }
    public void Valider()
    {
        if(Input.text.ToUpper() == "SOS")
        {
            all.SetActive(false);
            endTime = EnigmeManager.timercount;
            EnigmeManager.Finish(endTime);
            AlreadyPlayed = true;
        } else
        {
            EnigmeManager.AddMalus(100);
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
