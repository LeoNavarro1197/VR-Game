using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class SwitchCanvas : MonoBehaviour, IPointerClickHandler
{

    public GameObject firstCanvas;
    public GameObject secondCanvas;

    public GameObject canvas;

    void Awake()
    {
        firstCanvas = GameObject.FindGameObjectWithTag("FirstCanvas");

        //Obtener el padre
        canvas = GameObject.Find("UI");
        Transform parentTransform = canvas.transform;

        // Encontrar el GameObject desactivado en la jerarquía
        Transform transformSecondCanvas = parentTransform.Find("Formula");

        //Convertir a GameObject
        secondCanvas = transformSecondCanvas.gameObject;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        secondCanvas.SetActive(true);
        firstCanvas.SetActive(false);
    }
}
