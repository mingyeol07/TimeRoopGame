using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionEvent : MonoBehaviour
{
    protected Transform user;

    public void SetUser()
    {
        if(GameManager.Instance.User == null)
        {
            Debug.LogError("NUll User");
            return;
        }
        this.user = GameManager.Instance.User;
    }

    public abstract void  Initialize();
    public abstract void  InvokeEvent();
    public abstract bool  IsEnd();  
} 
