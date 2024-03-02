using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Asegúrate de incluir este namespace

public class ContadorMoneda : MonoBehaviour
{
    public Text resumenMonedasDisplay;

    void Start()
    {
        // Verifica el nombre de la escena actual
        if (SceneManager.GetActiveScene().name == "Nivel")
        {
            // Restablece el contador de monedas a cero al comienzo de la escena de juego
            PlayerPrefs.SetInt("TotalMonedas", 0);
        }

        // Actualiza el texto mostrado en el objeto de interfaz de usuario con el resumen de monedas almacenado en PlayerPrefs
        resumenMonedasDisplay.text = " " + PlayerPrefs.GetInt("TotalMonedas", 0);
    }

    void Update()
    {
        // Actualiza el texto mostrado en el objeto de interfaz de usuario con el resumen de monedas almacenado en PlayerPrefs
        resumenMonedasDisplay.text = " " + PlayerPrefs.GetInt("TotalMonedas", 0);
    }
}