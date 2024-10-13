using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    public float remainingTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime >  0.1f)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0.1f)
        {
            // Game Over Trigger
            SceneManager.LoadScene("GameOver");
        }
        remainingTime -= (Time.deltaTime / 60);
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
