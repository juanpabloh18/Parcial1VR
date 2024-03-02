using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBarController : MonoBehaviour
{
    public Image energyBarImage; // Referencia a la imagen que representa la barra de energía
    public float maxEnergy = 100f; // Valor máximo de la energía
    public float currentEnergy; // Valor actual de la energía

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
        // Ajusta el valor de llenado de la imagen según la energía actual
        energyBarImage.fillAmount = currentEnergy / maxEnergy;
    }
}