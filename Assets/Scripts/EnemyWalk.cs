using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public float moveSpeed = 5f;         // Enemy movement speed
    public float detectionRange = 10f;   // Range at which the enemy detects the player
    public LayerMask playerLayer;        // Layer mask for the player GameObject

    private bool isPlayerDetected = false;
    private Transform player;

    void Start()
    {
        // Find the player GameObject by tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        // Check if the playerObject is not null before accessing its transform
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    void Update()
    {
        // Check if the player reference is valid
        if (player != null)
        {
            // Check if the player is within the detection range
            DetectPlayer();

            // If the player is detected, move towards the player
            if (isPlayerDetected)
            {
                MoveTowardsPlayer();
            }
        }
    }

    void DetectPlayer()
    {
        if (player == null)
        {
            isPlayerDetected = false;
            return;
        }

        // Use a raycast to check if the player is within the detection range
        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.position - transform.position, detectionRange, playerLayer);

        // If the raycast hits the player, set isPlayerDetected to true
        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            isPlayerDetected = true;
        }
        else
        {
            isPlayerDetected = false;
        }
    }

    void MoveTowardsPlayer()
    {
        if (player == null)
        {
            return;
        }

        // Move towards the player
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
}
