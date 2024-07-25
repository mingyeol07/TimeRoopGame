// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class UpMovementAction : ActionEvent
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

        directionVec    = Vector3.up;
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
        float targetPositionY = transform.position.y + (directionVec.y * Constants.distanceBetweenTile);

        while (true)
        {
            if(transform.position.y >= targetPositionY)
            {
                user.transform.position = new Vector3(transform.position.x, targetPositionY, transform.position.z);
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
