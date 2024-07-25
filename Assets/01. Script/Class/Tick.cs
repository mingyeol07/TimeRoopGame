// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

[System.Serializable]
public class Tick
{
    [SerializeField]
    private List<ActionEvent> actions;

    public List<ActionEvent> Actions => actions;
}
