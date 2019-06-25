using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PilluleScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject PilluleBleue;
    public GameObject PilluleRouge;
    public GameObject plane;
    public Material R, B, normal;
    public Renderer m_Renderer;

    // Start is called before the first frame update
    void Start()
    {
        PilluleBleue.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        PilluleRouge.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        m_Renderer.material = normal;

    }

    public void OnButtonPressed (VirtualButtonBehaviour vb)
    {
        if (vb.name == "PilluleRouge")
        {
            m_Renderer.material = R;
        }
        if (vb.name == "PilluleBleu")
        {
            m_Renderer.material = B;
        }
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
