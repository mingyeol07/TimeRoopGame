// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class VirtualCoord2D : MonoBehaviour
{
    [SerializeField]
    private Vector3 virtualCoord2D = Vector3.zero;      

    public Vector3 VirtualCorrd2D 
    { 
        get => virtualCoord2D; 
        set {  virtualCoord2D = value; } 
    }
}
