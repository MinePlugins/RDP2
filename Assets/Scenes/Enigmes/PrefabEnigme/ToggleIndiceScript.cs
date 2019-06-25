using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToggleIndiceScript : MonoBehaviour
{
    public int numbindice = 0;

    // Start is called before the first frame update
    void Start()
    {
        INDICES.Add(Indice1);
        INDICES.Add(Indice2);
        INDICES.Add(Indice3);
        Indice1.SetActive(false);
        Indice2.SetActive(false);
        Indice3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Indice1;
    public GameObject Indice2;
    public GameObject Indice3;

    public List<GameObject> INDICES ;


    public void IndiceDisplay()
    {
        if (numbindice < 3)
        {
            numbindice += 1;
            INDICES[numbindice].SetActive(true);
        }
    }
}
