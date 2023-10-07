using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraExploracion : MonoBehaviour
{
    public Slider timeSlider; // Reference to the slider component

    public float totalTime; // Total time for exploring in seconds
    private float remainingTime; // Remaining time for exploring in seconds

    // Start is called before the first frame update
    void Start()
    {
        remainingTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime; // Subtract the time since the last frame

        // Update the slider value based on the remaining time
        timeSlider.value = remainingTime / totalTime;

        if (remainingTime <= 0f)
        {
            // End the game or take other actions when the time is up
        }
    }
}