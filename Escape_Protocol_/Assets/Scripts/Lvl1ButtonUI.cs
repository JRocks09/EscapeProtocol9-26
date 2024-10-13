using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.EventSystems;

public class Lvl1ButtonUI : MonoBehaviour
{
    public string TransScreen;

    public void NewGameButton()
    {
        Invoke("Delay", 0.5f);
    }

    void Delay()
    {
        SceneManager.LoadScene(TransScreen);
    }
}

