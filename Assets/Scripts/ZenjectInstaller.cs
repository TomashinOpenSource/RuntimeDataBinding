using UnityEngine;
using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    public Data Data;
    public SensorManager SensorManager;

    public override void InstallBindings()
    {
        Container.BindInstance(Data).AsSingle();
        Container.BindInstance(SensorManager).AsSingle();
    }
}
