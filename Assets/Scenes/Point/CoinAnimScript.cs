using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CoinAnimScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Coin_Animation.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Animator Coin_Animation;
    public void Anim()
    {
        Coin_Animation.Play("Coin_Animation");
        Debug.Log("Anim");
    }
}
