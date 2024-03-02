using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBarController : MonoBehaviour
{
    public Image energyBarImage; // Referencia a la imagen que representa la barra de energ�a
    public float maxEnergy = 100f; // Valor m�ximo de la energ�a
    public float currentEnergy; // Valor actual de la energ�a

    void Start()
    {
        currentEnergy = maxEnergy;
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
    }
}