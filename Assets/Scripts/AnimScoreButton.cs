using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnimScoreButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject CadreScore;
    public TextMeshProUGUI ScoreButtonText;
    // Start is called before the first frame update
    void Start()
    {
        CadreScore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (name == "ScoreButton")
        {
            CadreScore.SetActive(true);
            ScoreButtonText.fontStyle = FontStyles.Italic;


        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (name == "ScoreButton")
        {
            CadreScore.SetActive(false);
            ScoreButtonText.fontStyle = FontStyles.Normal;




        }
    }
}
