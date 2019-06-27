using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Cadre1;
    public TextMeshProUGUI StartButtonText;
    // Start is called before the first frame update
    void Start()
    {
        Cadre1.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartFunction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //GameObject test = GameObject.Find("StartButtonText");
        //TextMeshProUGUI test2 = test.GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        AudioSource audioData;
        if (name == "StartButton")
        {
            Cadre1.SetActive(true);
            StartButtonText.fontStyle = FontStyles.Italic;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);


        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (name == "StartButton")
        {
            Cadre1.SetActive(false);
            StartButtonText.fontStyle = FontStyles.Normal;




        }
    }
}
