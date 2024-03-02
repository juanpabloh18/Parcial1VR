using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public float tiempo = 0f;

    public Text textoTemporizador;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        textoTemporizador.text = "" + tiempo.ToString("f0");
    }
}
