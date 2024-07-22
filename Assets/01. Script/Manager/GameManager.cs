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

    // # ������Ƽ �б� ����
    public GridMap      GridMap => gridMap;

    private void Awake()
    {
        Instance = this;
    }
}
