using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string sceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "portal")
        {
            SceneManager.LoadScene(sceneName);
        }

    }
}
