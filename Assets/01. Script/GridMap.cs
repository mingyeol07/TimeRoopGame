using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    [SerializeField]
    private Tile[]      gridMap;
    [SerializeField]
    private Transform[] tiles;

    private void Initalize()
    {
        gridMap = new Tile[tiles.Length];


    }
}