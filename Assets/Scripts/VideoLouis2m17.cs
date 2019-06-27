using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoLouis2m17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeRight;
        StartCoroutine(ARload());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator ARload()
    {
        yield return new WaitForSeconds(138);
        Screen.orientation = ScreenOrientation.AutoRotation;
        SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);
    }
    public void Skip()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
        SceneManager.LoadScene("AR Recognition", LoadSceneMode.Single);

    }
}
