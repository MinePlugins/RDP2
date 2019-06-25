using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserManager : MonoBehaviour
{

    public InputField usernameLogin;
    public InputField passwordLogin;

    public InputField usernameRegister;
    public InputField passwordRegister;
    public InputField passwordAgainRegister;
    public InputField emailRegister;

    public void MoveToRegister()
    {
        SceneManager.LoadScene("Register");
    }

    public void Login()
    {
        Debug.Log("Login");
        StartCoroutine(LoginEnum());
    }

    IEnumerator LoginEnum()
    {
        WWWForm form = new WWWForm();
        Debug.Log(usernameLogin.text);
        Debug.Log(passwordLogin.text);
        form.AddField("username", usernameLogin.text);
        form.AddField("password", passwordLogin.text);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                WebResponse res = JsonUtility.FromJson<WebResponse>(www.downloadHandler.text);
                if (res.error)
                {
                    Debug.Log(res.message);
                }
                else
                {
                    SceneManager.LoadScene("Menu");
                }
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
                WebResponse res = JsonUtility.FromJson<WebResponse>(www.downloadHandler.text);
                if (res.error)
                {
                    Debug.Log(res.message);
                }
                else
                {
                    SceneManager.LoadScene("Login");
                }
            }
        }
    }
}
