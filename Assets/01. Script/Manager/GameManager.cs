// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]
    private GridMap     gridMap;

    // # 프로퍼티 읽기 전용
    public GridMap      GridMap => gridMap;

    private void Awake()
    {
        Instance = this;
    }
}
