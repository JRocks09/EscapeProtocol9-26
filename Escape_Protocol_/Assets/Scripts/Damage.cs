using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Takes the current player's health
    public playerHealth currentPlayerHealth;
    public float invincibilityTimer;
    private bool playerInvincible;
    public PlayerController playerController;

    // Sound
    AudioManager audioManager;


    // Damage
    public float damage;

    // Sound Initializing
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerInvincible = false;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        // If the player collides with the object
        if (collision.gameObject.CompareTag("Player") && !playerInvincible)
        {
            StartCoroutine(playerController.FlashRed());
            // Takes away health from the player based on the damage value
            collision.gameObject.GetComponent<playerHealth>().health -= damage;
            Invoke(nameof(InvincibilityOver), invincibilityTimer);
            playerInvincible = true;

      

            // Plays Damage Taken sound
            audioManager.PlaySFX(audioManager.damageTaken, 10.0f);

        }

    }

    void InvincibilityOver()
    {
        playerInvincible = false;
    }

    // Player Colliding with slime enemy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerController.KBCounter = playerController.KBTotalTime;
            if (collision.transform.position.x <= transform.position.x)
            {
                StartCoroutine(playerController.FlashRed());
                playerController.KnockFromRight = true;
            }

            if (collision.transform.position.x > transform.position.x)
            {
                StartCoroutine(playerController.FlashRed());
                playerController.KnockFromRight = false;
            }

            collision.gameObject.GetComponent<playerHealth>().health -= damage;
            audioManager.PlaySFX(audioManager.damageTaken, 10.0f);
        }
    }


}