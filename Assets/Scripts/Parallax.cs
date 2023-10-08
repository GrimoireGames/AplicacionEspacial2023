using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] private RawImage imagen;
    [SerializeField] private float x, y;

    void Update()
    {
        imagen.uvRect = new Rect(imagen.uvRect.position + new Vector2(x, y) * Time.deltaTime, imagen.uvRect.size);
    }
}
