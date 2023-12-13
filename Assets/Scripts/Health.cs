using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private HPCounter hpCounter;
    [SerializeField] private int health = 10;
    public GameObject Dead;
    private bool isDead = false;
    public Animator animator;

    private int MAX_HEALTH = 100;

    void Start()
    {
        hpCounter = GameObject.FindGameObjectWithTag("Canvas").GetComponent<HPCounter>();

        if (hpCounter == null)
        {
            Debug.LogError("HPCounter script not found on the Canvas GameObject.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Heal(1);
        }
    }

    private IEnumerator VisualIndicator(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;
        StartCoroutine(VisualIndicator(Color.red));

        if(health <= 0)
        {
            Die();
        }

        // Update the HP counter with the new health value
        if (hpCounter != null)
        {
            hpCounter.UpdateHPCounter(health);
        }

    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Heal amount");
        }

        this.health += amount;

        // Ensure health doesn't exceed a maximum value if needed
        // For example, if MAX_HEALTH is defined:
        health = Mathf.Min(health, MAX_HEALTH);

        // Update the HP counter with the new health value
        if (hpCounter != null)
        {
            hpCounter.UpdateHPCounter(health);
        }

        // Trigger the healing animation
        if (animator != null)
        {
            animator.SetBool("IsHealing", true);
            StartCoroutine(ResetHealingAnimation());
        }
        
    }

    private IEnumerator ResetHealingAnimation()
    {
        // Wait for a duration (adjust this based on your animation length)
        yield return new WaitForSeconds(0.5f);

        // Set the "IsHealing" parameter back to false
        if (animator != null)
        {
            animator.SetBool("IsHealing", false);
        }
    }

    public int GetCurrentHealth()
    {
        return health;
    }

    private void Die()
    {
        if (!isDead)
        {
            isDead = true;
            Debug.Log("Player dead!");
            StartCoroutine(DeathPauseAndShowUI());
        }
    }

    private IEnumerator DeathPauseAndShowUI()
    {
        Dead.SetActive(true);
        Time.timeScale = 0f;
        yield return new WaitForSeconds(3.0f);
        Time.timeScale = 1f;
    }
}
