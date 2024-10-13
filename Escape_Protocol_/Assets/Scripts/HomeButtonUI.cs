using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.EventSystems;

public class HomeButtonUI : MonoBehaviour
{
    public string HomeScreen;

    public void HomeButton()
    {
        Invoke("Delay", 0.5f);
    }

    void Delay()
    {
        SceneManager.LoadScene(HomeScreen);
    }
}


