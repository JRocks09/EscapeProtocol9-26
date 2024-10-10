using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool keyCollected;
    void Start()
    {
        keyCollected = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            keyCollected = true;
            gameObject.SetActive(false);
        }
    }
}
