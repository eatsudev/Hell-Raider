using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenUI : MonoBehaviour
{
    public void RetryButton()
    {
        SceneManager.LoadScene("Start");
    }

    public void BackToMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
