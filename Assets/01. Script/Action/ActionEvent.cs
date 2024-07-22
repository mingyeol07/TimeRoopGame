// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public abstract class ActionEvent : MonoBehaviour
{
    protected Transform user;

    public abstract void Initialize();          // 필수 구성 요소를 설정할 때 호출하는 메서드
    public abstract void InVokeAction();        // 특정 이벤트를 실행할 때 호출하는 메서드
    public abstract bool IsEnd();               // 현재 행동이 완료되었는지 여부를 확인하여 종료 상태를 반환하는 메서드

    private void Start()
    {
        user = transform.parent;
    }
}
