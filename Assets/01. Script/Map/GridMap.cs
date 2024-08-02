using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    private const int GridMapWidth  = 16;        // 맵 가로 크기
    private const int GridMapLength = 9;        // 맵 세로 크기 

    private Dictionary<Vector2, Tile> tileDictionary;

    private Tile[]    tiles;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        tiles          = GetComponentsInChildren<Tile>();

        tileDictionary = new Dictionary<Vector2, Tile>();

        int index      = 0;

        for ( int y = 0; y > -GridMapLength; y-- )
        {
            for ( int x = 0; x < GridMapWidth; x++ )
            {
                tiles[index].SetCoord(x, y);

                tileDictionary.Add(new Vector2(x, y), tiles[index]);

                index ++;
            }
        }
    }

    public bool IsDefaultTile(Vector2 userCoord)
    {
        if ( tileDictionary.ContainsKey(userCoord) && tileDictionary[userCoord].TileType == TileType.DefaultTile )
            return true;
        else 
            return false;
    }
}