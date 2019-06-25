using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnigmeManager : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI Malus;
    private float timercount;
    private string minutestext = "0";
    private string secondstext = "0";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetTimer(float tmp)
    {
        float minutes = Mathf.Floor(tmp / 60);

        float seconds = Mathf.RoundToInt(tmp % 60);
        if (minutes < 10)
        {
            minutestext = "0" + minutes.ToString();
        } else
        {
            minutestext = minutes.ToString();
        }
        if (seconds < 10)
        {
            secondstext = "0" + Mathf.RoundToInt(seconds).ToString();
        } else
        {
            secondstext = seconds.ToString();
        }
        Timer.SetText("TIMER " + minutestext + ":" + secondstext);
    }
    public void SetMalus(string Text)
    {
        Malus.SetText("MALUS " + Text);
    }
    // Update is called once per frame
    void Update()
    {
        timercount += Time.deltaTime;
        SetTimer(timercount);
    }
}
