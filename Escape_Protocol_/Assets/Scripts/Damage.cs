using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Takes the current player's health
    public playerHealth currentPlayerHealth;
    public float invincibilityTimer = 2f;
    public float cooldownTimer = 1f;
    private bool playerInvincible;
    private bool isOnCooldown;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        // If the player collides with the object
        if (collision.gameObject.CompareTag("Player") && !playerInvincible && !isOnCooldown)
        {
            // Takes away health from the player based on the damage value
            collision.gameObject.GetComponent<playerHealth>().health -= damage;
            MakeInvulnerable();

            // Plays Damage Taken sound
            audioManager.PlaySFX(audioManager.damageTaken, 10.0f);
        }
    }

    void MakeInvulnerable()
    {
        playerInvincible = true;
        Invoke("EndInvulnerability", invincibilityTimer);
    }

    void EndInvulnerability()
    {
        playerInvincible = false;
        isOnCooldown = true;
        Invoke("EndCooldown", cooldownTimer);
    }

    void EndCooldown()
    {
        isOnCooldown = false;
    }
}