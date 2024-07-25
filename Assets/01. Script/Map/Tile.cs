// # Unity
using UnityEngine;

public class Tile : MonoBehaviour
{ 
    [SerializeField]
    private TileType   tileType;         // 타일 종류 
    [SerializeField]
    private Vector2    coord2D;          // 타일 좌표

    // # 프로퍼티 읽기 전용
    public TileType    TileType  => tileType;
    public Vector2     Coord2D   => coord2D;

    public void SetCoord(int x, int y)
    {
        coord2D = new Vector2(x, y);
    }
}