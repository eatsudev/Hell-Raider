using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenUI : MonoBehaviour
{
    public Transform playerSpawnPoint;
    public void RetryButton()
    {
        // Reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Reset player position
        ResetPlayerPosition();

        // Ensure time is running at normal speed
        Time.timeScale = 1f;
    }

    private void ResetPlayerPosition()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null && playerSpawnPoint != null)
        {
            player.transform.position = playerSpawnPoint.position;
        }
    }

    public void BackToMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
