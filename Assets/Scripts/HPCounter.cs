using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPCounter : MonoBehaviour
{
    public Health playerHealth; // Reference to the Health script on the player GameObject
    public Text hpText; // Reference to the UI Text element

    void Start()
    {
        // Find and store a reference to the Health script on the player GameObject
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();

        // Ensure the playerHealth reference is valid
        if (playerHealth == null)
        {
            Debug.LogError("Health script not found on the player GameObject.");
        }

        // Find and store a reference to the UI Text element
        hpText = GetComponent<Text>();

        // Ensure the hpText reference is valid
        if (hpText == null)
        {
            Debug.LogError("Text component not found on the same GameObject.");
        }
    }

    void Update()
    {
        // Update the UI Text with the current health value
        if (playerHealth != null && hpText != null)
        {
            hpText.text = ": " + playerHealth.GetCurrentHealth().ToString();
        }
    }
}
