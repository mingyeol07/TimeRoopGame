// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class VirtualCoord2D : MonoBehaviour
{
    [SerializeField]
    private Vector2Int virtualCoord2D = Vector2Int.zero;      // �÷��̾��� ���� ��ġ ( ��ǥ )

    // # ������Ƽ �б� ����
    public Vector2Int VirtualCorrd2D => virtualCoord2D;
}
