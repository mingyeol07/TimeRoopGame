using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionEvent : MonoBehaviour
{
    public static ActionEvent Instance { get; private set; }

    [SerializeField]
    private List<ActionEvent> actions = new List<ActionEvent>();

    private void Awake()
    {
        Instance = this;
    }

    public void AddActions(ActionEvent actionEvent)
    {
        actions.Add(actionEvent);
    }
}
