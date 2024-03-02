using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparecerTexto : MonoBehaviour
{
    public Text texto;
    public GameObject boton; // Referencia al objeto del botón

    private bool textoCompleto = false; // Variable para controlar si todo el texto se ha mostrado

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeText());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !textoCompleto)
        {
            MostrarTodoTexto();
        }
    }

    IEnumerator TypeText()
    {
        string mensaje = "Bienvenidos a Astro Bite donde conocerán los beneficios de estas barras energéticas a través de un juego tipo endless runner." +
            "\n\n" +
            "Para jugar usa la tecla A para ir a la izquierda y la tecla D para ir a la derecha para ir esquivando objetos." +
            "\n\n" +
            "Tu barra de energía irá disminuyendo con el tiempo. Si se termina tu energía se acabará la partida. Para evitar que tu energía se acabe tendrás que recoger una barra energética Astro Bite para aumentarla y te dará como beneficio más velocidad." +
            "\n\n" +
            "Durante el recorrido podrás recolectar monedas que te darán una recompensa al final.";

        foreach (char character in mensaje)
        {
            texto.text += character;
            yield return new WaitForSecondsRealtime(0.035f);
        }

        textoCompleto = true; // Se marca el texto como completo
        MostrarBoton();
    }

    public void MostrarBoton()
    {
        boton.gameObject.SetActive(true);
    }

    public void MostrarTodoTexto()
    {
        StopAllCoroutines(); // Detener la animación de aparición de texto
        texto.text = ""; // Borrar el texto actual
        texto.text = "Bienvenidos a Astro Bite donde conocerán los beneficios de estas barras energéticas a través de un juego tipo endless runner." +
            "\n\n" +
            "Para jugar usa la tecla A para ir a la izquierda y la tecla D para ir a la derecha para ir esquivando objetos." +
            "\n\n" +
            "Tu barra de energía irá disminuyendo con el tiempo. Si se termina tu energía se acabará la partida. Para evitar que tu energía se acabe tendrás que recoger una barra energética Astro Bite para aumentarla y te dará como beneficio más velocidad." +
            "\n\n" +
            "Durante el recorrido podrás recolectar monedas que te darán una recompensa al final.";

        MostrarBoton(); // Mostrar el botón después de mostrar todo el texto
    }
}
