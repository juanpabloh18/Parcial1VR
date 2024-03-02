using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleController : MonoBehaviour
{
    // Nombre de la escena a la que cambiar cuando el jugador toca el obstáculo
    public string sceneToLoad = "Resumen";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Cambia a la escena especificada
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}