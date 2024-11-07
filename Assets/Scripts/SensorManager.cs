using System;
using UnityEngine;
using Zenject;

public class SensorManager : MonoBehaviour
{
    [Inject] private Data data;
    
    [SerializeField] private Sensor sensor;
    
    private void Awake()
    {
        if (sensor == null)
        {
            sensor = gameObject.AddComponent<Sensor>();
        }
    }

    private void StartStreaming()
    {
        data.PressureData1 = sensor.Variant1;
        data.PressureData2 = sensor.Variant2;
    }
}
