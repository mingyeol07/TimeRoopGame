// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class RightMovementAction : ActionEvent
{
    private MovementTransform2D     movement;
    private VirtualCoord2D          virtualCoord;
    private Animator                animator;

    private Vector3                 directionVec;
    private bool                    isEnd;

    private void Start()
    {
        Initialize();
    }

    public override void Initialize()
    {
        user            = transform;

        movement        = user?.GetComponent<MovementTransform2D>();
        virtualCoord    = user?.GetComponent<VirtualCoord2D>();
        animator        = user?.GetComponent<Animator>();

        directionVec    = Vector3.right;
        isEnd           = false;
    }

    [ContextMenu("invoke action")]
    public override void InVokeAction()
    {
        StartCoroutine(InvokeActionCoroutine());
    }
    
    private IEnumerator InvokeActionCoroutine()
    {
        isEnd = false;

        // 이동할 위치가 기본 타일이 아니면 실행 X
        if (!GameManager.Instance.GridMap.IsDefaultTile(virtualCoord.VirtualCorrd2D + directionVec))
        {
            isEnd = true;

            Debug.Log("브레이크 실행");
            yield break;
        }

        animator?.SetBool("IsMovement", true);

        virtualCoord.VirtualCorrd2D += directionVec;

        movement.MoveTo(directionVec);

        yield return StartCoroutine(MoveInDirection());

        animator?.SetBool("IsMovement", false);

        isEnd = true;
    }

    private IEnumerator MoveInDirection()
    {
        float targetPositionX = transform.position.x + (directionVec.x * Constants.distanceBetweenTile);

        while (true)
        {
            if(transform.position.x >= targetPositionX)
            {
                user.transform.position = new Vector3(targetPositionX, transform.position.y, transform.position.z);
                movement.MoveTo(Vector3.zero);

                break;
            }

            yield return null;
        }
    }

    public override bool IsEnd()
    {
        return isEnd;
    }
}
