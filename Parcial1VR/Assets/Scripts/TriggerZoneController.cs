using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneController : MonoBehaviour
{
    public Animator animator;
    private bool isPowerUpActivated = false;
    public MonoBehaviour movimientoPersonaje; // Referencia al componente que controla el movimiento del personaje
    private Collider triggerCollider; // Referencia al Collider del objeto
    private Renderer objectRenderer; // Referencia al renderizador del objeto

    public Canvas canvas; // Referencia al Canvas que se desea mostrar
    public CanvasController canvasController; // Referencia al script que controla el Canvas

    public AudioClip powerUpSound; // Variable para el audio

    public float energyBarValue;
    public EnergyBarController energyBarController;

    public float amountToReduce = 10f; // Cantidad de energía a reducir por segundo
    public float amountToIncrease = 50f; // Cantidad de energía a aumentar al recoger el objeto

    void Start()
    {
        triggerCollider = GetComponent<Collider>();
        objectRenderer = GetComponent<Renderer>();
        StartCoroutine(ReduceEnergyOverTime());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPowerUpActivated)
        {
            animator.Play("PowerUP");
            isPowerUpActivated = true;
            StartCoroutine(StopMovementForDuration(2f)); // Detener durante 2 segundos

            // Aumentar la velocidad del personaje
            other.gameObject.GetComponent<LogicaPersonaje>().AumentarVelocidad(5.0f, 4f); // Aumenta la velocidad en 3.0f durante 2 segundos

            triggerCollider.enabled = false;
            objectRenderer.enabled = false;

            GetComponent<AudioSource>().PlayOneShot(powerUpSound);

            energyBarController.IncreaseEnergy(amountToIncrease);

            // Reinicia la variable para permitir que la energía vuelva a disminuir
            isPowerUpActivated = false;
        }
    }
    

    IEnumerator StopMovementForDuration(float duration)
    {
        movimientoPersonaje.enabled = false;
        canvas.gameObject.SetActive(true); // Activa el objeto del Canvas
        canvasController.ShowCanvas(); // Llama al método para mostrar el contenido del Canvas
        yield return new WaitForSeconds(duration);
        canvas.gameObject.SetActive(false); // Desactiva el objeto del Canvas
        movimientoPersonaje.enabled = true;
        animator.Play("Correr");
    }

    IEnumerator ReduceEnergyOverTime()
    {
        while (true)
        {
            if (!isPowerUpActivated)
            {
                energyBarController.ReduceEnergy(amountToReduce * Time.deltaTime); // Reduce la energía por segundo
            }
            yield return new WaitForSeconds(1f); // Espera un segundo antes de la siguiente reducción
        }
    }
}