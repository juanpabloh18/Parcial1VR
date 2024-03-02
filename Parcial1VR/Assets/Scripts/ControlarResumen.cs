using System.Collections;
using UnityEngine;

public class ControlarResumen : MonoBehaviour
{
    public GameObject canvas0a15;
    public GameObject canvas16a30;
    public GameObject canvas31a60;

    void Start()
    {
        StartCoroutine(MostrarCanvasCorrespondienteConRetraso());
    }

    IEnumerator MostrarCanvasCorrespondienteConRetraso()
    {
        // Espera 3 segundos antes de continuar
        yield return new WaitForSeconds(3);

        MostrarCanvasCorrespondiente();
    }

    void MostrarCanvasCorrespondiente()
    {
        int totalMonedas = PlayerPrefs.GetInt("TotalMonedas", 0);

        // Asegúrate de desactivar todos los Canvas primero
        canvas0a15.SetActive(false);
        canvas16a30.SetActive(false);
        canvas31a60.SetActive(false);

        // Activa el Canvas correspondiente según el número de monedas recogidas
        if (totalMonedas >= 0 && totalMonedas <= 15)
        {
            canvas0a15.SetActive(true);
        }
        else if (totalMonedas >= 16 && totalMonedas <= 30)
        {
            canvas16a30.SetActive(true);
        }
        else if (totalMonedas > 30) // Ajustado para mayor claridad
        {
            canvas31a60.SetActive(true);
        }
    }
}