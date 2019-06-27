using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnigmeText : MonoBehaviour
{
    public TextMeshProUGUI enigmeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enigmeText.text = "Enigmes " + GameManager.numbEnigme + "/" + GameManager.maxEnigme;
    }
}
