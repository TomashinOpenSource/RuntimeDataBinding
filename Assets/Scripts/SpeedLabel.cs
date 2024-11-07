using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

[UxmlElement]
public partial class SpeedLabel : Label
{
    private int speed;
    [CreateProperty, UxmlAttribute]
    public int Speed
    {
        get => speed;
        set
        {
            speed = value;
            text = speed.ToString();
        }
    }
    public SpeedLabel()
    {
        style.flexGrow = 1;
        style.fontSize = 32;
        style.color = Color.black;
        style.unityTextAlign = TextAnchor.MiddleCenter;
    }
    
    public void SetPressureData1(PressureDataVariant1 pressureData)
    {
        dataSource = pressureData;
        SetBinding(nameof(Speed), pressureData.SpeedBinding);
    }
    
    public void SetPressureData2(PressureDataVariant2 pressureData)
    {
        dataSource = pressureData;
        SetBinding(nameof(Speed), pressureData.Speed.Binding);
    }
}
