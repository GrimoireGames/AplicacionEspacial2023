using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    Slider barra;
    public static Barra slider;
    public TextMeshProUGUI txtValor;

    private void Awake()
    {
        barra = GetComponent<Slider>();
        slider = this;       
    }

    public void ActualizarBarra(float valorMax, float valorAct)
    {
        float porcentaje = valorAct / valorMax;
        barra.value = porcentaje;
        int porcentajeEntero = Mathf.RoundToInt(porcentaje * 100);
        txtValor.text = porcentajeEntero + "%";
    }
}
