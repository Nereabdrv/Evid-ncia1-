using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticPulse : MonoBehaviour
{
    public ActionBasedController controller;
    public float intensidad = 0.5f;
    public float duracion = 0.5f;

    void Start()
    {
        if (controller != null)
        {
            controller.SendHapticImpulse(intensidad, duracion);
        }
    }
}

