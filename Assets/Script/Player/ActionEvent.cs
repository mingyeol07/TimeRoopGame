using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionEvent : MonoBehaviour
{
    public abstract void  Initialize();
    public abstract void  InvokeEvent();
    public abstract bool  IsEnd();  
} 
