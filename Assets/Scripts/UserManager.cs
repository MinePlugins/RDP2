using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UserManager : MonoBehaviour
{

    public InputField usernameRegister;
    public InputField passwordRegister;
    public InputField passwordAgainRegister;
    public InputField emailRegister;

    public void Login()
    {
        Debug.Log("Login");
        StartCoroutine(LoginEnum());
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

    public void Register()
    {
        //Debug.Log("Register");
        if (passwordRegister.text == passwordAgainRegister.text)
        {
            StartCoroutine(RegisterEnum());
        }
        else
        {
            Debug.Log("password does not match");
        }
    }

    IEnumerator RegisterEnum()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", usernameRegister.text);
        form.AddField("password", passwordRegister.text);
        form.AddField("email", emailRegister.text);

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
}
