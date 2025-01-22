using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Road : MovingObject
{
    protected override void UpdateCustom()
    {
        if (transform.position.y < -25f)
        {
            transform.position = new Vector3(transform.position.x, 50f, transform.position.z);
        }
    }
}
