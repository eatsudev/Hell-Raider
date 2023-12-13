using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract : MonoBehaviour
{
    public GameObject canvasDialogue;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "npc")
        {
            canvasDialogue.SetActive(true);
        }

    }
}
