// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class MovementTransform2D : MonoBehaviour
{
    [SerializeField]
    private float           movementSpeed;  // 움직임 속도

    private Vector3         direction;      // 움직일 방향 
    
    public float MovementSpeed => movementSpeed;

    public void MoveTo(Vector3 direction)
    {
        this.direction = direction;
    }

    private void Update()
    {
        if (direction == Vector3.zero) return;

        transform.position += direction * movementSpeed * Time.deltaTime;
    }
}
