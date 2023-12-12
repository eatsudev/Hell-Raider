using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Image hpBarFill; // Reference to the Image component of the filled HP bar
    public int maxHealth = 10;

    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHPBar();
    }

    public void UpdateHP(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Ensure health doesn't go below 0 or above maxHealth
        UpdateHPBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHPBar()
    {
        float fillAmount = (float)currentHealth / maxHealth;
        hpBarFill.fillAmount = fillAmount;
    }

    private void Die()
    {
        Debug.Log("Player is dead");
        // You can add additional logic for player death, such as restarting the level or showing a game over screen.
    }
}
