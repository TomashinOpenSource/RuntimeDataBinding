using System;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public class BindableProperty<T>
{
    [SerializeField] public T value;
    [SerializeField] private BindingUpdateTrigger updateTrigger;
    [SerializeField] private BindingMode bindingMode;

    public string PropertyName { get; }

    [CreateProperty] public T Value
    {
        get => value;
        set
        {
            this.value = value;
            binding?.MarkDirty();
        }
    }

    private DataBinding binding;
    public DataBinding Binding => binding ??= new DataBinding
    {
        dataSourcePath = new PropertyPath($"{PropertyName}.{nameof(Value)}"),
        updateTrigger = updateTrigger,
        bindingMode = bindingMode,
    };

    public BindableProperty(T initialValue, string propertyName, BindingUpdateTrigger updateTrigger = BindingUpdateTrigger.WhenDirty, BindingMode bindingMode = BindingMode.ToTarget)
    {
        value = initialValue;
        PropertyName = propertyName;
        this.updateTrigger = updateTrigger;
        this.bindingMode = bindingMode;
    }
}
