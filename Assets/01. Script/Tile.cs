// # Unity
using UnityEngine;

[System.Serializable]
public class Tile
{ 
    [SerializeField]
    private Transform     tile;
    [SerializeField]
    private Vector2Int    coord2D;

    public Vector2Int Coord2D => coord2D;

    public Tile(int x, int y)
    {
        coord2D = new Vector2Int(x, y);
    }
}