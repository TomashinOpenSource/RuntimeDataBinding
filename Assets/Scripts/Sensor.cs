using System;
using System.Diagnostics;
using UnityEngine;
using Zenject;

public class Sensor : MonoBehaviour
{
    [Inject] private Data data;
    
    [SerializeField] private PressureDataVariant1 _variant1;
    [SerializeField] private PressureDataVariant2 _variant2;
    
    public PressureDataVariant1 Variant1 => _variant1;
    public PressureDataVariant2 Variant2 => _variant2;

    private Stopwatch stopwatch;
    
    private void Awake()
    {
        stopwatch = new Stopwatch();
        _variant1 = new PressureDataVariant1();
        _variant2 = new PressureDataVariant2();
    }

    private void Start()
    {
        stopwatch.Restart();
    }

    private void Update()
    {
        if (stopwatch.ElapsedMilliseconds > 1000)
        {
            _variant1.Speed += 1;
            _variant2.Speed.Value += 1;
            stopwatch.Restart();
        }
    }
}
