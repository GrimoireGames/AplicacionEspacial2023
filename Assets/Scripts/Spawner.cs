using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float fuerzaDeImpulso = 10f;
    public float tiempoDeEspera = 2f;
    public float rangoDeSpawn = 5f;

    void Start()
    {
        StartCoroutine(SpawnEnemigos());
    }

    IEnumerator SpawnEnemigos()
    {
        while (true)
        {
            tiempoDeEspera = Random.Range(0.75f, 1.25f);
            float posX = transform.position.x + Random.Range(-rangoDeSpawn, rangoDeSpawn);

            GameObject nuevoEnemigo = Instantiate(enemigoPrefab, new Vector3(posX, transform.position.y, 0f), Quaternion.identity);
            Rigidbody2D rb = nuevoEnemigo.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.down * fuerzaDeImpulso, ForceMode2D.Impulse);
            Destroy(nuevoEnemigo, 3f);
            yield return new WaitForSeconds(tiempoDeEspera);
        }
    }
}
