using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorAura : MonoBehaviour
{
    public GameObject aura;

    private void Start()
    {
        aura.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mouse"))
        {
            aura.SetActive(true);
            Debug.Log("Aura activada");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Mouse"))
        {
            aura.SetActive(false);
            Debug.Log("Aura desactivada");
        }
    }
}
