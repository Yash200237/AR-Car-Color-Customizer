using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenController : MonoBehaviour
{
    public void ARScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void HomeScene()
    {
        SceneManager.LoadScene("Home");
    }

     public void Quit()
    {
        Application.Quit();

    }
}
