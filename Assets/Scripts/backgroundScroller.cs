using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backgroundScroller : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private float _speed;
    public PlayerMovementScript playerScript;
 
    void Update()
    {
        Vector2 movement = playerScript.GetComponent<PlayerMovementScript>().GetMovementDirection();
        _img.uvRect = new Rect(_img.uvRect.position + movement * _speed * Time.deltaTime, _img.uvRect.size);
    }
}
