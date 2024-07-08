using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proveedores : MonoBehaviour
{
    public GameObject[] buttonPrefabs; // Array de prefabs de los botones
    public RectTransform canvasRectTransform; // RectTransform del Canvas
    public Vector3[] positions; // Posiciones preestablecidas para los botones

    void Start()
    {
        if (buttonPrefabs.Length != 3)
        {
            Debug.LogError("Debe haber exactamente 3 prefabs de botones.");
            return;
        }

        if (positions.Length != 3)
        {
            Debug.LogError("Debe haber exactamente 3 posiciones preestablecidas.");
            return;
        }

        PlaceButtons();
    }

    void PlaceButtons()
    {
        // Crear una lista de �ndices de posiciones disponibles
        List<int> availableIndices = new List<int> { 0, 1, 2 };

        for (int i = 0; i < buttonPrefabs.Length; i++)
        {
            // Obtener un �ndice aleatorio de la lista de �ndices disponibles
            int randomIndex = Random.Range(0, availableIndices.Count);

            // Obtener la posici�n correspondiente al �ndice aleatorio
            Vector2 position = positions[availableIndices[randomIndex]];


            // Eliminar el �ndice de la lista para evitar repetici�n
            availableIndices.RemoveAt(randomIndex);

            // Instanciar el bot�n correspondiente al prefab
            GameObject newButton = Instantiate(buttonPrefabs[i], canvasRectTransform);

            // Obtener el RectTransform del nuevo bot�n
            RectTransform buttonRectTransform = newButton.GetComponent<RectTransform>();

            // Establecer la posici�n del bot�n
            buttonRectTransform.anchoredPosition = position;
        }
    }
}
