using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class controllerPlane : MonoBehaviour
{
    UduinoManager manager;
    public float FlySpeedForward = 8;
    public float FlySpeedSideways = 4;

    void Start()
    {
        manager = UduinoManager.Instance;
        manager.pinMode(AnalogPin.A0, PinMode.Input);
    }

    void Update()
    {
        int analogValue = manager.analogRead(AnalogPin.A0);
        float value = (float)analogValue / 1000.0f;

        transform.position += transform.forward * FlySpeedForward * Time.deltaTime;

        if (value < 0.45)
        {
            transform.position += transform.right * FlySpeedSideways * (1-value) * Time.deltaTime;
        }
        else if (value > 0.55)
        {
            transform.position += -transform.right * FlySpeedSideways * value * Time.deltaTime;
        }
    }
}
