using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light;

    public Color color1;
    public Color color2;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.color = color1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            light.color = color2;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            light.color = color1;
    }
}
