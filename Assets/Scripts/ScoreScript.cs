using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


public class ScoreScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Cadre1;
    public TextMeshProUGUI ScoreButtonText;
    public GameObject ScoreButton;

    // Start is called before the first frame update
    void Start()
    {
        Cadre1.SetActive(false);
        ScoreText1.text = "";
        ScoreText2.text = "";
        ScoreText3.text = "";
        ScoreText4.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Text ScoreText1;
    public Text ScoreText2;
    public Text ScoreText3;
    public Text ScoreText4;
    public void ScoreDisplay()
    {
        StartCoroutine(ScoreEnum());
        ScoreButton.SetActive(false);
    }

    IEnumerator ScoreEnum()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:8080/score.php?user_id="+UserManager.userid))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                var res = JsonConvert.DeserializeObject<ScoreResponse>(www.downloadHandler.text);

                //ScoreResponse res = JsonUtility.FromJson<ScoreResponse>(www.downloadHandler.text);

                if (res.error)
                {
                    Debug.Log(res.message);
                }
                else
                {
                    int i = 1;
                    foreach(var user in res.score)
                    {
                        switch (i)
                        {
                            case 1:
                                ScoreText1.text = i + "  " + user.username + "  " + "  " + user.score;
                                break;
                            case 2:
                                ScoreText2.text = i + "  " + user.username + "  " + "  " + user.score;
                                break;
                            case 3:
                                ScoreText3.text = i + "  " + user.username + "  " + "  " + user.score;
                                break;
                            case 4:
                                ScoreText4.text = i + "  " + user.username + "  " + "  " + user.score;
                                break;
                        }
                        i++;
                    }
                }
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (name == "ScoreButton")
        {
            Cadre1.SetActive(true);
            ScoreButtonText.fontStyle = FontStyles.Italic;


        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (name == "ScoreButton")
        {
            Cadre1.SetActive(false);
            ScoreButtonText.fontStyle = FontStyles.Normal;




        }
    }
}
