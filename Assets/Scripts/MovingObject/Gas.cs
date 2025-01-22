using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MovingObject
{
    protected override void UpdateCustom()
    {
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}