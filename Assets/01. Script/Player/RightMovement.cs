// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;
using DG.Tweening;

public class RightMovement : ActionEvent
{
    private readonly float tileSpacing = 1.5f;

    [SerializeField]
    private float           moveSpeed;

    private Vector3         direction;

    private bool            isEnd;

    private WaitForSeconds  waitForSeconds; 

    public override void Initialize()
    {
        SetUser();

        direction = Vector3.right;

        waitForSeconds = new WaitForSeconds(moveSpeed + 0.1f);
    }

    public override void InvokeEvent()
    {
        StartCoroutine(Co_InvokeEvent());        
    }

    private IEnumerator Co_InvokeEvent()
    {
        isEnd             = false;
        
        Vector3 targetVec = user.position + ( direction * tileSpacing );
        user.DOMove(targetVec, moveSpeed);

        yield return waitForSeconds;

        isEnd             = true;
    }

    public override bool IsEnd()
    {
        return isEnd;
    }
}
