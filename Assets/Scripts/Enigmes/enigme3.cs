using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enigme3 : MonoBehaviour
{
    public GameObject all;
    public TMP_InputField Input;
    private float endTime;
    // Start is called before the first frame update
    void Start()
    {
        
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
            EnigmeManager.Finish(endTime);
        }
        else
        {
            EnigmeManager.AddMalus(100);
        }
    }
}