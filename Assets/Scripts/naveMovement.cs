using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naveMovement : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    public float timer;
    public float timeChange;

    public int hits;
    PlanetManager planetManager;

    public string Planeta1, Planeta2, Planeta3;

    private void Start()
    {
        timer = 0f;
        timeChange = Random.Range(50f, 80f);

        planetManager = GameObject.Find("PlanetManager").GetComponent<PlanetManager>();
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
        if (planetManager.whichPlanet == 1)
        {
            SceneManager.LoadScene(Planeta1);
        }
        if (planetManager.whichPlanet == 2)
        {
            SceneManager.LoadScene(Planeta2);
        }
        if (planetManager.whichPlanet == 3)
        {
            SceneManager.LoadScene(Planeta3);
        }
    }

    //L�gica para saber cuantas veces fue golpeado
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Meteorito"))
        {
            Destroy(collision.gameObject);
            //hits++;
            planetManager.daño++;
        }
    }
}
