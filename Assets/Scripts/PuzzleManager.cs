using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] Levels;
    int currentLevel;
    public void correctAnswer()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("LastBoss");
        }
    }
}
