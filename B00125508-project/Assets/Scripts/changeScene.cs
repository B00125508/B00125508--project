using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public string URL = "https://github.com/B00125508/B00125508--project";
    public void GoToSene1()
    {
        SceneManager.LoadScene("Scene 1");
    }


    public void GoToSene2()
    {
        SceneManager.LoadScene("Scene 2");
    }
    public void loadUrl()
    {
        Application.OpenURL(URL);
    }

}
