using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveMovement : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float velocidadBala = 10f;

    public float timer;

    private void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector3 desplazamiento = new Vector3(movimientoHorizontal, 0f, 0f) * velocidadMovimiento * Time.deltaTime;
        transform.Translate(desplazamiento);

        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            CambioPlaneta();
        }
    }

    void Disparar()
    {
        GameObject bala = Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);
        Rigidbody2D rbBala = bala.GetComponent<Rigidbody2D>();
        rbBala.velocity = new Vector2(0f, velocidadBala);
        Destroy(bala, 3f);
    }

    void CambioPlaneta()
    {
        //Agregar la mamera del cambiar al planeta deseado
    }
}
