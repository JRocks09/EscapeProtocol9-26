using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.EventSystems;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string TransScreen = "Level1";


    public void NewGameButton()
    {
        SceneManager.LoadScene(TransScreen);
    }
}

