using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public int numPlaneta;
    public PlanetManager planetManager;
    public GameObject planetManagerObj;
    public bool visitado;

    private void Awake()
    {
        planetManagerObj = GameObject.Find("PlanetManager");
        planetManager = planetManagerObj.GetComponent<PlanetManager>();
    }

    public void OnMouseDown()
    {
        if(!visitado)
        {
            Debug.Log("Cambio");
            planetManager.GuardarPlaneta(numPlaneta);
            visitado = true;
        }
        else if (visitado)
        {
            Debug.Log("Visitado");
        }
    }
}
