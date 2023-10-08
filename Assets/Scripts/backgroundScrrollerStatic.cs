using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backgroundScrrollerStatic : MonoBehaviour
{
    [SerializeField] private RawImage _backgroundimg;
    [SerializeField] private float _x, _y;

    private void Update()
    {
        _backgroundimg.uvRect = new Rect(_backgroundimg.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _backgroundimg.uvRect.size);
    }
}
