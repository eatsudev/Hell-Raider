using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject canvasBrailleHint;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "chest")
        {
            canvasBrailleHint.SetActive(true);
        }

    }
}
