using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    // Takes the current player's health
    public playerHealth currentPlayerHealth;
    public float invincibilityTimer = 3;
    private bool playerInvincible;

    // Damage
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        playerInvincible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        // If the player collides with the object
        if (collision.gameObject.CompareTag("Player") && !playerInvincible)
        {
            // Takes away health from the player based on the damage value
            // currentPlayerHealth.health -= damage;
            collision.gameObject.GetComponent<playerHealth>().health -= damage;
            Invoke(nameof(InvincibilityOver), invincibilityTimer);
            playerInvincible = true;
        }
    }

    void InvincibilityOver()
    {
        playerInvincible = false;
    }
}