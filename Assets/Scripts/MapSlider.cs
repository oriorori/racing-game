using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSlider : MonoBehaviour
{
    public float slideSpeed;
    public List<GameObject> roads;
    private List<GameObject> slidingObjects;

    void Awake()
    {
        slidingObjects = new List<GameObject>();
        
    }
    
    void Update()
    {
        
    }

}
