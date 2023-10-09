using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetManager : MonoBehaviour
{
    public static PlanetManager Instance;
    public int whichPlanet;
    public bool Planeta1Visitado, Planeta2Visitado, Planeta3Visitado;
    public int daño;

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
        if (planeta == 1)
        {
            if (!Planeta1Visitado)
            {
                SceneManager.LoadScene("Navecita");
                whichPlanet = planeta;
                Planeta1Visitado = true;
            }
            else
            {
                Debug.Log("Ya visitaste este planeta");
            }
        }
        if (planeta == 2)
        {
            if (!Planeta2Visitado)
            {
                SceneManager.LoadScene("Navecita");
                whichPlanet = planeta;
                Planeta2Visitado = true;
            }
            else
            {
                Debug.Log("Ya visitaste este planeta");
            }
        }
        if (planeta == 3)
        {
            if (!Planeta3Visitado)
            {
                SceneManager.LoadScene("Navecita");
                whichPlanet = planeta;
                Planeta3Visitado = true;
            }
            else
            {
                Debug.Log("Ya visitaste este planeta");
            }
        }
        
    }
}
