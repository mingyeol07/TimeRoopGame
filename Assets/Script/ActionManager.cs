using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static ActionManager Instance { get; private set;}

    private List<ActionEvent> actionEvents = new List<ActionEvent>();

    private void Awake()
    {
        Instance = this;
    }

    public void AddActionEvents(ActionEvent action)
    {
        actionEvents.Add(action);
    }
}