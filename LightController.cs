using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light luz;
    public float intensidadMax = 2f;
    public float velocidad = 1f;

    void Update()
    {
        if (luz != null)
        {
            luz.intensity = Mathf.PingPong(Time.time * velocidad, intensidadMax);
        }
    }
}
