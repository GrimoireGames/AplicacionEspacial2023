using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetManager : MonoBehaviour
{
    public static PlanetManager Instance;
    public int whichPlanet;
    public bool Planeta1Visitado, Planeta2Visitado, Planeta3Visitado;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GuardarPlaneta(int planeta)
    {
        SceneManager.LoadScene("Navecita");
        whichPlanet = planeta;
    }
}
