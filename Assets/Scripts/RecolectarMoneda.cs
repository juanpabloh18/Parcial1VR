using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarMoneda : MonoBehaviour
{
    public AudioSource moneda;

    private void OnTriggerEnter(Collider other)
    {
        moneda.Play();

        
        int totalMonedas = PlayerPrefs.GetInt("TotalMonedas", 0);
        totalMonedas++;
        PlayerPrefs.SetInt("TotalMonedas", totalMonedas);

        // Desactiva este objeto de moneda
        gameObject.SetActive(false);
    }
}