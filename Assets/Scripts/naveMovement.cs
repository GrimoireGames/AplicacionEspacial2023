using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveMovement : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    public float timer;
    public float timeChange;

    public int hits;

    private void Start()
    {
        timer = 0f;
        timeChange = Random.Range(60f, 90f);
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 desplazamiento = new Vector3(movimientoHorizontal, movimientoVertical, 0f) * velocidadMovimiento * Time.deltaTime;
        transform.Translate(desplazamiento);

        timer += Time.deltaTime;
        Barra.slider.ActualizarBarra(timeChange, timer);
        if (timer >= timeChange)
        {
            CambioPlaneta();
        }
    }

    void CambioPlaneta()
    {
        //Agregar la mamera del cambiar al planeta deseado
    }

    //Lógica para saber cuantas veces fue golpeado
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Meteorito"))
        {
            Destroy(collision.gameObject);
            hits++;
        }
    }
}
