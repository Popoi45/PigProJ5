using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class rollPlane : MonoBehaviour
{
    UduinoManager manager;

    void Start()
    {
        manager = UduinoManager.Instance;
        manager.pinMode(AnalogPin.A0, PinMode.Input);
    }

    void Update()
    {
        int analogValue = manager.analogRead(AnalogPin.A0);
        float value = (float)analogValue / 1000.0f;

        if (value < 0.45)
        {
            float roll = Mathf.Lerp(0, 30, Mathf.Abs(1 - value)) * -Mathf.Sign(1 - value);
            transform.localRotation = Quaternion.Euler(Vector3.forward * roll);
        }
        else if (value > 0.55)
        {
            float roll = Mathf.Lerp(0, 30, Mathf.Abs(value)) * -Mathf.Sign(value);
            transform.localRotation = Quaternion.Euler(Vector3.forward * -roll);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(Vector3.forward * 0);
        }
    }
}
