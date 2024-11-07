using System;
using UnityEngine;
using UnityEngine.UIElements;
using Zenject;

public class Screen : MonoBehaviour
{
    [Inject] private Data data;
    public SpeedLabel speedLabel1, speedLabel2;
    
    private void Awake()
    {
        var document = GetComponent<UIDocument>();
        if (document.rootVisualElement == null)
            return;

        var root = document.rootVisualElement;
        
        speedLabel1 = root.Q<SpeedLabel>("SpeedLabel1");
        speedLabel2 = root.Q<SpeedLabel>("SpeedLabel2");
    }

    private void Start()
    {
        speedLabel1.SetPressureData1(data.PressureData1);
        speedLabel2.SetPressureData2(data.PressureData2);
    }
}
