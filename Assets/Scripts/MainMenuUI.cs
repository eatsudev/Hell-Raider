using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    //[SerializeField] private AudioSource clickSound;
    public void PlayButton()
    {
        //clickSound.Play();
        SceneManager.LoadScene("Start");
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
