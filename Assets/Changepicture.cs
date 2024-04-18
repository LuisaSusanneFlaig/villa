using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changepicture : MonoBehaviour
{
    public Material[] materials;
    private int currentIndex = 0;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = materials[currentIndex];
    }

    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Check if the ray hits this object
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Increase the index and loop back to the start if necessary
                currentIndex = (currentIndex + 1) % materials.Length;
                // Update the material to the next one in the array
                renderer.material = materials[currentIndex];
            }
        }
    }
}
