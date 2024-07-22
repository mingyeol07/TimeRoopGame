// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class LeftMovementAction : ActionEvent
{
    private MovementTransform2D     movement;
    private VirtualCoord2D          virtualCoord;

    private Vector3                 directionVec;
    private bool                    isEnd;

    public override void Initialize()
    {
        movement        = user.GetComponent<MovementTransform2D>();
        virtualCoord    = user.GetComponent<VirtualCoord2D>();

        directionVec    = Vector3.left;
        isEnd           = false;
    }

    public override void InVokeAction()
    {

    }
    
    private IEnumerator InvokeActionCoroutine()
    {
        int x = (int)directionVec.x;
        int y = (int)directionVec.y;

        // 이동할 위치가 기본 타일이 아니면 실행 X
        if (!GameManager.Instance.GridMap.IsDefaultTile(virtualCoord.VirtualCorrd2D + new Vector2Int(x, y)))
        {
             yield break;
        }

        movement.MoveTo(directionVec);

        yield return MoveInDirection();
    }

    private IEnumerator MoveInDirection()
    {
        while (true)
        {

            yield return null;
        }
    }

    public override bool IsEnd()
    {
        return isEnd;
    }
}
