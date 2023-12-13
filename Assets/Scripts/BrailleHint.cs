using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrailleHint : MonoBehaviour
{
    public GameObject canvasBrailleHint;

    public void CloseButton()
    {
        canvasBrailleHint.SetActive(false);
    }
}

