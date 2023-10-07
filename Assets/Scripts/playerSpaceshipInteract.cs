using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerSpaceshipInteract : MonoBehaviour
{
    public float interactionDistance = 2f; // The distance at which the player can interact with the spaceship
    public LayerMask spaceshipLayer; // The layer that the spaceship is on
    public TMP_Text interactionText; // The UI text element to display when the player is close to the spaceship

    private bool isNearSpaceship = false;

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
            // Do something when the player presses the E key while near the spaceship
            Debug.Log("Player interacted with spaceship");
        }
    }
}
