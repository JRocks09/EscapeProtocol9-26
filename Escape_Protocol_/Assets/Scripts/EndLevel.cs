using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    Collectible collectibleScript;
    Timer timerScript;

    // Start is called before the first frame update
    void Start()
    {
        collectibleScript = GameObject.FindGameObjectWithTag("Collectible").GetComponent<Collectible>();
        timerScript = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(collectibleScript.keyCollected && other.gameObject.CompareTag("Player"))
        {
            // Transition to Alright Ending Scene
            if (timerScript.remainingTime <= 240)
            {
                SceneManager.LoadScene("Alright_Ending");
            }

            // Transition to Good Ending Scene
            else if (timerScript.remainingTime > 240)
            {
                SceneManager.LoadScene("Good_Ending");
            }
        }
    }
}
