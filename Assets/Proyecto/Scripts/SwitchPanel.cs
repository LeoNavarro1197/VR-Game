using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{

    public GameObject firstCanvas;
    public GameObject secondCanvas;

    public void ChangeCanvas()
    {
        secondCanvas.SetActive(true);
        firstCanvas.SetActive(false);
    }
}
