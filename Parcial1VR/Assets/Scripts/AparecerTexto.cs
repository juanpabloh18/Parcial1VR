using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparecerTexto : MonoBehaviour
{
    public Text texto;
    public GameObject boton; // Referencia al objeto del bot�n

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
        string mensaje = "Bienvenidos a Astro Bite donde conocer�n los beneficios de estas barras energ�ticas a trav�s de un juego tipo endless runner." +
            "\n\n" +
            "Para jugar usa la tecla A para ir a la izquierda y la tecla D para ir a la derecha para ir esquivando objetos." +
            "\n\n" +
            "Tu barra de energ�a ir� disminuyendo con el tiempo. Si se termina tu energ�a se acabar� la partida. Para evitar que tu energ�a se acabe tendr�s que recoger una barra energ�tica Astro Bite para aumentarla y te dar� como beneficio m�s velocidad." +
            "\n\n" +
            "Durante el recorrido podr�s recolectar monedas que te dar�n una recompensa al final.";

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
        StopAllCoroutines(); // Detener la animaci�n de aparici�n de texto
        texto.text = ""; // Borrar el texto actual
        texto.text = "Bienvenidos a Astro Bite donde conocer�n los beneficios de estas barras energ�ticas a trav�s de un juego tipo endless runner." +
            "\n\n" +
            "Para jugar usa la tecla A para ir a la izquierda y la tecla D para ir a la derecha para ir esquivando objetos." +
            "\n\n" +
            "Tu barra de energ�a ir� disminuyendo con el tiempo. Si se termina tu energ�a se acabar� la partida. Para evitar que tu energ�a se acabe tendr�s que recoger una barra energ�tica Astro Bite para aumentarla y te dar� como beneficio m�s velocidad." +
            "\n\n" +
            "Durante el recorrido podr�s recolectar monedas que te dar�n una recompensa al final.";

        MostrarBoton(); // Mostrar el bot�n despu�s de mostrar todo el texto
    }
}
