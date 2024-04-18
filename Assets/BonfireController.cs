using UnityEngine;
using UnityEngine.VFX;

public class BonfireController : MonoBehaviour
{
    private Light bonfireLight;
    private VisualEffect visualEffect;
    private bool isFireOn = true;

    private float minValue = 932.6323f;
    private float maxValue = 2662.5632f;
    private float flickerSpeed = 10f;

    void Start()
    {
        bonfireLight = GetComponent<Light>();
        visualEffect = GetComponent<VisualEffect>();

        if (bonfireLight == null)
        {
            Debug.LogError("Light component not found on the object!");
        }
        if (visualEffect == null)
        {
            Debug.LogError("Visual Effect component not found on the object!");
        }

        // Start with both light and visual effect off
        bonfireLight.enabled = false;
        visualEffect.enabled = false;
    }

    void Update()
    {
        // Toggle fire on/off when the "B" key is pressed
        if (Input.GetKeyDown(KeyCode.B))
        {
            ToggleFire();
        }

        // Update intensity if the fire is on
        if (isFireOn)
        {
            float intensity = Mathf.Lerp(minValue, maxValue, Mathf.PingPong(Time.time * flickerSpeed, 1));
            bonfireLight.intensity = intensity;
        }
    }

    void ToggleFire()
    {
        isFireOn = !isFireOn;

        // Enable or disable the light and visual effect accordingly
        bonfireLight.enabled = isFireOn;
        visualEffect.enabled = isFireOn;
    }
}
