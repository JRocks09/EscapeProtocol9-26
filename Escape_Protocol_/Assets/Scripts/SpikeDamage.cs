using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    // Takes the current player's health
    public playerHealth currentPlayerHealth;

    // Damage
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // If the player collides with the object
        if (other.gameObject.CompareTag("Player"))
        {
            // Takes away health from the player based on the damage value
            // currentPlayerHealth.health -= damage;
            other.gameObject.GetComponent<playerHealth>().health -= damage;
        }
    }
}