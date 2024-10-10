using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string StartScreen = "Level1";

    public void NewGameButton()
    {
        SceneManager.LoadScene(StartScreen);
    }
}
