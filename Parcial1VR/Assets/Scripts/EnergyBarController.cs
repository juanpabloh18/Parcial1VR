using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Importa el espacio de nombres para manejar las escenas

public class EnergyBarController : MonoBehaviour
{
    public Image energyBarImage; // Referencia a la imagen que representa la barra de energ�a
    public float maxEnergy = 100f; // Valor m�ximo de la energ�a
    public float currentEnergy; // Valor actual de la energ�a
    public string nextSceneName = "NombreDeTuSiguienteEscena"; // Aseg�rate de reemplazar esto con el nombre de tu escena

    void Start()
    {
        currentEnergy = maxEnergy;
        UpdateEnergyBar();
    }

    public void IncreaseEnergy(float amount)
    {
        currentEnergy += amount;
        UpdateEnergyBar();
    }

    public void ReduceEnergy(float amount)
    {
        currentEnergy -= amount;
        UpdateEnergyBar();
    }

    void UpdateEnergyBar()
    {
        // Ajusta el valor de llenado de la imagen seg�n la energ�a actual
        energyBarImage.fillAmount = currentEnergy / maxEnergy;

        // Verifica si la energ�a actual es 0 o menos
        if (currentEnergy <= 0)
        {
            // Cambia a la siguiente escena
            SceneManager.LoadScene("Resumen");
        }
    }
}