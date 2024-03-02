using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorMoneda : MonoBehaviour
{
    // Referencia al objeto de interfaz de usuario donde se mostrará el resumen de monedas
    public Text resumenMonedasDisplay;

    // Este método se llama antes de la primera actualización del cuadro
    void Start()
    {
        // Restablece el contador de monedas a cero al inicio del juego, solo si no existe
        if (!PlayerPrefs.HasKey("TotalMonedas"))
        {
            PlayerPrefs.SetInt("TotalMonedas", 0);
        }
    }

    void Update()
    {
        // Actualiza el texto mostrado en el objeto de interfaz de usuario con el resumen de monedas almacenado en PlayerPrefs
        resumenMonedasDisplay.text = " " + PlayerPrefs.GetInt("TotalMonedas", 0);
    }
}