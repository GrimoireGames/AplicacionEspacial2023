using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public int numPlaneta;
    public PlanetManager planetManager;
    public GameObject planetManagerObj;

    private void Awake()
    {
        planetManagerObj = GameObject.Find("PlanetManager");
        planetManager = planetManagerObj.GetComponent<PlanetManager>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Cambio");
        planetManager.GuardarPlaneta(numPlaneta);
    }
}
