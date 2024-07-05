using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static ActionManager Instance { get; private set;}

    private List<ActionEvent> actionEvents = new List<ActionEvent>();

    private bool isUserTurn;

    private void Awake()
    {
        Instance   = this;
    }

    private void Start()
    {
        isUserTurn = false;
    }

    public void AddActionEvents(ActionEvent action)
    {
        actionEvents.Add(action);
    }

    public void OnStart()
    {
        isUserTurn = true;

        StartCoroutine(Co_OnStart()); 
    }

    private IEnumerator Co_OnStart()
    {
        Debug.Log("실행");

        for(int i = 0; i < actionEvents.Count; i++)
        {
            actionEvents[i].Initialize();
        }


        while( actionEvents != null )
        {
            actionEvents[0].InvokeEvent();

            yield return actionEvents[0].IsEnd();

            actionEvents.RemoveAt(0);

        }
    }
}