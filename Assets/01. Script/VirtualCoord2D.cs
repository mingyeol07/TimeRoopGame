// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class VirtualCoord2D : MonoBehaviour
{
    [SerializeField]
    private Vector2Int virtualCoord2D = Vector2Int.zero;      // 플레이어의 가상 위치 ( 좌표 )

    // # 프로퍼티 읽기 전용
    public Vector2Int VirtualCorrd2D => virtualCoord2D;
}
