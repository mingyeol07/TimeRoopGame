// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class MovementTransform2D : MonoBehaviour
{
    [SerializeField]
    private float    movementSpeed;  // ������ �ӵ�

    private Vector3  direction;      // ������ ���� 

    public void MoveTo(Vector3 direction)
    {
        this.direction = direction;
    }

    private void Update()
    {
        if (direction == Vector3.zero) return;

        transform.position += direction * direction * Time.deltaTime;
    }
}
