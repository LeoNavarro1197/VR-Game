using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proveedores : MonoBehaviour
{
    public GameObject[] buttonPrefabs;
    public RectTransform canvasRectTransform;
    public Vector3[] positions;

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
        List<int> availableIndices = new List<int> { 0, 1, 2 };

        for (int i = 0; i < buttonPrefabs.Length; i++)
        {
            int randomIndex = Random.Range(0, availableIndices.Count);
            Vector2 position = positions[availableIndices[randomIndex]];

            availableIndices.RemoveAt(randomIndex);
            GameObject newButton = Instantiate(buttonPrefabs[i], canvasRectTransform);

            RectTransform buttonRectTransform = newButton.GetComponent<RectTransform>();
            buttonRectTransform.anchoredPosition = position;
        }
    }
}
