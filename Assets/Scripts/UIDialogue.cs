using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDialogue : MonoBehaviour
{
    public GameObject canvasDialogue1;
    public GameObject canvasDialogue2;

    public void NextButton()
    {
        canvasDialogue1.SetActive(false);
        canvasDialogue2.SetActive(true);
    }

    public void CloseDialogue()
    {
        canvasDialogue2.SetActive(false);
    }
}
