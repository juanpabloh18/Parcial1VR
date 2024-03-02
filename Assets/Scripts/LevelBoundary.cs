using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float ladoizquierdo = 1f; //definir el rango dependiendo del tamaño del terreno
    public static float ladoderecho = 6.4f; //definir el rango dependiendo del tamaño del terreno
    public float derechointerno;
    public float izquierdointerno;

    private void Update()
    {
        derechointerno = ladoizquierdo;
        izquierdointerno = ladoderecho;
    }







}
