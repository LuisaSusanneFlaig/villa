using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        // Get the Light component attached to the GameObject
        myLight = GetComponent<Light>();

        // Initially disable the light
        myLight.enabled = false;
    }

    void Update()
    {
        // Check if the "L" key is pressed
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Toggle the light state
            myLight.enabled = !myLight.enabled;
        }
    }
}
