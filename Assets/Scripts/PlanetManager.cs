using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetManager : MonoBehaviour
{
    public static PlanetManager Instance;
    public int whichPlanet;

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
