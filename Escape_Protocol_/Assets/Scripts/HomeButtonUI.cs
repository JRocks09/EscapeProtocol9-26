using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.EventSystems;

public class ButtonUI1 : MonoBehaviour
{
    [SerializeField] private string HomeScreen = "Title";


    public void HomeButton()
    {
        SceneManager.LoadScene(HomeScreen);
    }
}


