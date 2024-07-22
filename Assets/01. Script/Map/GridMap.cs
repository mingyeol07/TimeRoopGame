using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    private const int GridMapWidth  = 6;        // 맵 가로 크기
    private const int GridMapLength = 4;        // 맵 세로 크기 

    private Dictionary<Vector2Int, Tile> tileDictionary;

    private Tile[]    tiles;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        tiles          = GetComponentsInChildren<Tile>();

        tileDictionary = new Dictionary<Vector2Int, Tile>();

        int index      = 0;

        for ( int y = 0; y > -GridMapLength; y-- )
        {
            for ( int x = 0; x < GridMapWidth; x++ )
            {
                tiles[index].SetCoord(x, y);

                tileDictionary.Add(new Vector2Int(x, y), tiles[index]);

                index ++;
            }
        }
    }

    public bool IsDefaultTile(Vector2Int userCoord)
    {
        if ( tileDictionary.ContainsKey(userCoord) && tileDictionary[userCoord].TileType == TileType.DefaultTile )
            return true;
        else 
            return false;
    }
}