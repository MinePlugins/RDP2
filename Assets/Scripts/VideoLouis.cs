using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoLouis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ARload());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator ARload()
    {
        yield return new WaitForSeconds(18);
        SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
    }
}
