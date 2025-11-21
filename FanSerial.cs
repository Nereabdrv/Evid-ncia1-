using UnityEngine;
using System.IO.Ports;

public class FanSerial : MonoBehaviour
{
    SerialPort puerto;

    void Start()
    {
        puerto = new SerialPort("COM3", 115200); // Cambia el COM
        puerto.Open();
    }

    public void ActivarViento(int velocidad)
    {
        if (puerto != null && puerto.IsOpen)
        {
            puerto.WriteLine("FAN:" + velocidad);
        }
    }

    void OnApplicationQuit()
    {
        if (puerto != null && puerto.IsOpen)
        {
            puerto.Close();
        }
    }
}
