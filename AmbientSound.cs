using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public AudioSource audioAmbiental;

    void Start()
    {
        if (audioAmbiental != null)
        {
            audioAmbiental.loop = true;
            audioAmbiental.Play();
        }
    }
}
