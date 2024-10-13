using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Sound
    AudioManager audioManager;

    public bool keyCollected;
    void Start()
    {
        keyCollected = false;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            keyCollected = true;
            gameObject.SetActive(false);
        }
        // Sound
        audioManager.PlaySFX(audioManager.keyPick, 8.0f);
    }
}
