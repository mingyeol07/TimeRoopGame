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
        direction = Vector3.right;

        isEnd     = false;

        waitForSeconds = new WaitForSeconds(moveSpeed + 0.1f);
    }

    public override void InvokeEvent()
    {
        StartCoroutine(Co_InvokeEvent());        
    }

    private IEnumerator Co_InvokeEvent()
    {
        Vector3 targetVec = transform.position + direction;
        transform.DOMove(targetVec, moveSpeed);

        yield return waitForSeconds;

        isEnd             = true;
    }

    public override bool IsEnd()
    {
        return isEnd;
    }
}
