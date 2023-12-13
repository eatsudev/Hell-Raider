using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public Transform playerSpawnPoint;
    public void PlayButton()
    {
        //clickSound.Play();
        SceneManager.LoadScene("Start");
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

    public void ControlsButton()
    {
        //clickSound.Play();
        SceneManager.LoadScene("Controls");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
        //clickSound.Play();
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("quitted");
        //clickSound.Play();
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
        //clickSound.Play();
    }
}
