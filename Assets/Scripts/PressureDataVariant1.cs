using System;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public sealed class PressureDataVariant1
{
    [SerializeField] private int speed;
    [CreateProperty] public int Speed
    {
        get => speed;
        set
        {
            speed = value;
            speedBinding?.MarkDirty();
        }
    }
    private DataBinding speedBinding;
    public DataBinding SpeedBinding => speedBinding ??= new DataBinding {
        dataSourcePath = new PropertyPath(nameof(Speed)),
        updateTrigger = BindingUpdateTrigger.WhenDirty,
        bindingMode = BindingMode.ToTarget,
    };
}
