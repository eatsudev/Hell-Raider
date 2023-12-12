using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPCounter : MonoBehaviour
{
    private Text hpText;
    private GameObject playerObject;
    void Start()
    {
        GameObject canvasObject = GameObject.FindWithTag("Canvas");

        if (canvasObject != null)
        {
            hpText = canvasObject.GetComponentInChildren<Text>();
        }

        if (hpText == null)
        {
            Debug.LogError("Text component not found in the Canvas.");
        }
        else
        {
            Debug.Log("HPCounter initialized successfully.");
        }

        // Find the player GameObject by tag and store a reference to it
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        // Check if the playerObject is still valid before updating the HP counter
        if (playerObject != null && hpText != null)
        {
            hpText.text = ": " + GetCurrentHealth().ToString();
        }
    }

    public void UpdateHPCounter(int health)
    {
        if (playerObject != null && hpText != null)
        {
            hpText.text = ": " + health.ToString();
        }
    }

    int GetCurrentHealth()
    {
        // Assuming the player's health script is on the player GameObject
        Health playerHealth = playerObject.GetComponent<Health>();
        return playerHealth != null ? playerHealth.GetCurrentHealth() : 0;
    }
}
