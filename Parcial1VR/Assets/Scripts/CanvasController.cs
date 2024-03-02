using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject[] elementsToHide; // Lista de elementos a ocultar

    public void ShowCanvas()
    {
        // Mostrar el Canvas
        gameObject.SetActive(true);

        // Ocultar elementos específicos
        foreach (GameObject element in elementsToHide)
        {
            element.SetActive(false);
        }
    }
}