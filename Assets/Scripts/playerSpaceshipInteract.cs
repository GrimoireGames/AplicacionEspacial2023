using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSpaceshipInteract : MonoBehaviour
{
    public Transform interactionText; // The text to display when the player is near the spaceship
    public string sceneToLoad; // The name of the scene to load when the player interacts with the spaceship

    private bool isNearSpaceship;

    private void Start()
    {
        interactionText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spaceship"))
        {
            isNearSpaceship = true;
            interactionText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spaceship"))
        {
            isNearSpaceship = false;
            interactionText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (isNearSpaceship && Input.GetKeyDown(KeyCode.E))
        {
            // Load the specified scene when the player presses the E key while near the spaceship
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}