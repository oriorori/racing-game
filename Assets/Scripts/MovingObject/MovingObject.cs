using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class MovingObject : MonoBehaviour
{
    public float moveSpeed = 2f;
    
    void Update()
    {
        transform.position += Vector3.down * (moveSpeed * Time.deltaTime);
        UpdateCustom();
    }
    
    protected virtual void UpdateCustom() { }
}
