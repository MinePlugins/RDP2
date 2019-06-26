using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class EnigmeManager : MonoBehaviour
{
    public static EnigmeManager instance;
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI Malus;
    public GameObject finish;
    public TextMeshProUGUI finishtext;
    public static int malus = 500;
    public static float timercount;
    private static string minutestext = "0";
    private static string secondstext = "0";
    private static bool nextGo = false;
    private static float nextTime = 0;
    public GameObject Indice1;
    public GameObject Indice2;
    public GameObject Indice3;
    public int numbindice = 0;
    public List<GameObject> Indices;
    // Start is called before the first frame update
    void Start()
    {
        finish.SetActive(false);
        instance = this;
        Indices.Add(Indice1);
        Indices.Add(Indice2);
        Indices.Add(Indice3);
        Indice1.SetActive(false);
        Indice2.SetActive(false);
        Indice3.SetActive(false);

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
        Malus.SetText("SCORE " + Text);
    }
    public static void AddMalus(int tmp)
    {
        malus -= tmp;
    }

    public void IndiceDisplay()
    {
        if (numbindice < 3)
        {
            AddMalus(50);
            Indices[numbindice].SetActive(true);
            numbindice += 1;

        }
    }
    IEnumerator ScoreSet(int score)
    {
        WWWForm form = new WWWForm();

        form.AddField("score", score);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/score.php?ID="+UserManager.UseID, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                WebResponse res = JsonUtility.FromJson<WebResponse>(www.downloadHandler.text);
                if (res.error)
                {
                    Debug.Log(res.message);
                }
                else
                {
                    SceneManager.LoadScene("Menu");
                }
            }
        }
    }
    public static void Finish(float endTime)
    {
        float minutes = Mathf.Floor(endTime / 60);
        float seconds = Mathf.RoundToInt(endTime % 60);

        if (minutes < 10)
        {
            minutestext = "0" + minutes.ToString();
        }
        else
        {
            minutestext = minutes.ToString();
        }
        if (seconds < 10)
        {
            secondstext = "0" + Mathf.RoundToInt(seconds).ToString();
        }
        else
        {
            secondstext = seconds.ToString();
        }

        instance.finishtext.SetText("Bravos ! Vous avez-mis " + minutes + ":" + seconds + " minutes");
        nextTime = 5;
        nextGo = true;
        instance.finish.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        timercount += Time.deltaTime;
        SetTimer(timercount);
        SetMalus(malus.ToString());
        if (nextGo && Time.time > nextTime)
        {
            Debug.Log("HEHEHEH");
            SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
        }
    }
}
