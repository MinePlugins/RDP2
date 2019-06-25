using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PilluleScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject PilluleBleue;
    public GameObject PilluleRouge;

    // Start is called before the first frame update
    void Start()
    {
        PilluleBleue.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        PilluleRouge.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed (VirtualButtonBehaviour vb)
    {
        Debug.Log("BluePress");
    }

    public void OnPilluleRouge(VirtualButtonBehaviour vb)
    {
        Debug.Log("ta mere est vraiment un femme sympathique");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
