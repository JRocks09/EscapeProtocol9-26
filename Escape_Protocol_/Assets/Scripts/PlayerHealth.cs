using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// To access the unity ui elements, in this case being the square
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    // Health
    public float health;

    // Max Health
    public float maxHealth;

    // Image of Health Bar
    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }
}