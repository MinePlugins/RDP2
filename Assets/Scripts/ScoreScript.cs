using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


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
        ScoreButton.SetActive(false);
        ScoreText1.text = "RANK    " + "PSEUDO    " + "    SCORE";
        ScoreText2.text = "RANK    " + "PSEUDO    " + "    SCORE";
        ScoreText3.text = "RANK    " + "PSEUDO    " + "    SCORE";
        ScoreText4.text = "RANK    " + "PSEUDO    " + "    SCORE";
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
