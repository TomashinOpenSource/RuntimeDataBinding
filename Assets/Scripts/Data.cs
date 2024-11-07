using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Project/Data/Data", order = 0)]
public class Data : ScriptableObject
{
    public PressureDataVariant1 PressureData1;
    public PressureDataVariant2 PressureData2;
}
