// # Systems
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;
    [SerializeField] private List<GameObject> tileSpaces = new List<GameObject>();
    [SerializeField] private Dictionary<Transform, Transform> tileInSpace;

    private void Awake()
    {
        instance = this;
    }

    /// <summary>
    /// ����� Ÿ�� ������ �������� �������� �Լ�
    /// </summary>
    /// <returns></returns>
    public Vector2 GetNearTileSpace(Vector2 tilePosition)
    {
        float nearTilePlaceDistance = float.MaxValue;
        Vector2 nearTilePlacePosition = Vector2.zero;

        for (int i = 0; i < tileSpaces.Count; i++)
        {
            float tileDistance = Vector2.Distance((Vector2)tileSpaces[i].transform.position, tilePosition);

            if(tileDistance < nearTilePlaceDistance)
            {
                nearTilePlaceDistance = tileDistance;
                nearTilePlacePosition = (Vector2)tileSpaces[i].transform.position;
            }
        }

        return nearTilePlacePosition;
    }
}
