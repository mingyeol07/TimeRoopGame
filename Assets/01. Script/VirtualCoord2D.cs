// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class VirtualCoord2D : MonoBehaviour
{
    [SerializeField]
    private Vector2 virtualCoord2D = Vector2.zero;      

    public Vector2 VirtualCorrd2D 
    { 
        get => virtualCoord2D; 
        set {  virtualCoord2D = value; } 
    }
}
