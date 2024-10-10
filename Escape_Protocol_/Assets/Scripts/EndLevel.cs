using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    Collectible collectibleScript;

    // Start is called before the first frame update
    void Start()
    {
        collectibleScript = GameObject.FindGameObjectWithTag("Collectible").GetComponent<Collectible>();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(collectibleScript.keyCollected && other.gameObject.CompareTag("Player"))
        {
            // Code for end of level and Ending Scene transition will go here
            print("end of level");
        }
    }
}
