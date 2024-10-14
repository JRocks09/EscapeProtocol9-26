using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndLevel : MonoBehaviour
{
    public Collectible collectibleScript;
    public Timer timerScript;
    public Collider2D player;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Collider2D>();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(collectibleScript.keyCollected && other == player)
        {
            // Transition to Alright Ending Scene
            if (timerScript.remainingTime <= 120)
            {
                SceneManager.LoadScene("Alright_Ending");
            }

            // Transition to Good Ending Scene
            else if (timerScript.remainingTime > 120)
            {
                SceneManager.LoadScene("Good_Ending");
            }
        }
    }
}
