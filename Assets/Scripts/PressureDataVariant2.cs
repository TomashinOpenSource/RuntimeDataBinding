using System;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public sealed class PressureDataVariant2
{
    [CreateProperty] public BindableProperty<int> Speed = new BindableProperty<int>(0, "Speed");
}
