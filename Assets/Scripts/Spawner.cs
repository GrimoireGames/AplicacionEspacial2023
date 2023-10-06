using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objetoPrefab;
    public int cantidadObjetos = 10;
    public float fuerzaLanzamiento = 5f;
    public float intervaloLanzamiento = 2f;

    void Start()
    {
        StartCoroutine(LanzarObjetosCoroutine());
    }

    IEnumerator LanzarObjetosCoroutine()
    {
        while (true)
        {
            GameObject objeto = Instantiate(objetoPrefab, transform.position, Quaternion.identity);
            Vector2 direccionLanzamiento = Random.insideUnitCircle.normalized;

            Rigidbody2D rbObjeto = objeto.GetComponent<Rigidbody2D>();
            rbObjeto.AddForce(direccionLanzamiento * fuerzaLanzamiento, ForceMode2D.Impulse);
            yield return new WaitForSeconds(intervaloLanzamiento);
        }
    }
}
