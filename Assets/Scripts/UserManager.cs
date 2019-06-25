using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class UserManager : MonoBehaviour
{
    void Login()
    {
    }

    void Register()
    {
        RegisterEnum();
    }

    IEnumerator RegisterEnum()
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormFileSection("username", "louis"));
        formData.Add(new MultipartFormFileSection("password", "password1234"));
        formData.Add(new MultipartFormFileSection("email", "louis@estiam.com"));

        UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/register.php", formData);
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
