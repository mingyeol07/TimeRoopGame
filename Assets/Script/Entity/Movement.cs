using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : ActionEvent
{
    private readonly float tileSpacing = 1.5f;
    
    private void OnMove(Vector3 direction)
    {
        transform.position += direction * tileSpacing;
    }
}
