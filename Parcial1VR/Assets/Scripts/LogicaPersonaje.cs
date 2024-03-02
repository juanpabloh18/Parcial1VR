using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogicaPersonaje : MonoBehaviour
{
    public float VelocidadPersonaje = 3.0f;
    public float VelocidadIzqDer = 4.0f;
    public float FuerzaSalto = 5.0f;

    private bool enSuelo = true;
    private Rigidbody rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * VelocidadPersonaje, Space.World);

        // Controlar la animación de correr o saltar según la velocidad del Rigidbody
        if (rb.velocity.y > 0.1f)
        {
            anim.Play("Salto");
        }
        else if (Mathf.Abs(rb.velocity.x) > 0.1f)
        {
            anim.Play("Correr");
        }

        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.up * FuerzaSalto, ForceMode.Impulse);
            enSuelo = false;
            
            anim.Play("Salto"); 
        }

        // Movimiento lateral
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.ladoizquierdo)
            {
                transform.Translate(Vector3.left * Time.deltaTime * VelocidadIzqDer);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.ladoderecho)
            {
                transform.Translate(Vector3.left * Time.deltaTime * VelocidadIzqDer * -1);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }
    }
}
