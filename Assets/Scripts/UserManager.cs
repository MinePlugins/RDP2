using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class UserManager : MonoBehaviour
{
    public void Login()
    {
        Debug.Log("Login");
        StartCoroutine(LoginEnum());
    }

    public void Register()
    {
        Debug.Log("Register");
        StartCoroutine(RegisterEnum());
    }

    IEnumerator RegisterEnum()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", "louis");
        form.AddField("password", "louis1234");
        form.AddField("email", "louis@estiam.com");

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/register.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    IEnumerator LoginEnum()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", "louis");
        form.AddField("password", "louis1234");

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
