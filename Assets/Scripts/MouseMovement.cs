using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float velocidadSeguimiento = 5f;

    void Update()
    {
        Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, posicionMouse, velocidadSeguimiento);
    }
}
