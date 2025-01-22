using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Road Position", menuName = "SO/Road Position")]
public class RoadPositionSO : ScriptableObject
{
    public List<float> positions = new List<float>();
}
