using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static ActionManager Instance { get; private set;}

    private List<ActionEvent> actionEvents = new List<ActionEvent>();

    private void Awake()
    {
        Instance   = this;
    }

    public void AddActionEvents(ActionEvent action)
    {
        actionEvents.Add(action);
    }

    public void OnStart()
    {
        StartCoroutine(OnStartCoroutine()); 
    }

    private IEnumerator OnStartCoroutine()
    {
        for(int i = 0; i < actionEvents.Count; i++)
        {
            actionEvents[i].Initialize();
        }

        int actionNumber = 0;

        while(true)
        {
            actionEvents[actionNumber].InvokeEvent();

            yield return new WaitUntil(() => actionEvents[actionNumber].IsEnd());

            actionNumber++;

            if(actionNumber == actionEvents.Count)
            {
                actionEvents.Clear();
                break;
            }

            yield return null;
        }
    }
}