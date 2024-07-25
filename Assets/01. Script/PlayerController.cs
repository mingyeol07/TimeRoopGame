// # System
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private ActionEvent[] actionEvents;

    private int inputIndex = 10000;

    private void Update()
    {
        if (inputIndex != 10000 && !actionEvents[inputIndex].IsEnd()) return;

        if(Input.GetKeyDown(KeyCode.Q))
        {
            actionEvents[0].InVokeAction();
            inputIndex = 0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            actionEvents[1].InVokeAction();
            inputIndex = 1;
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            actionEvents[2].InVokeAction();
            inputIndex = 2;
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            actionEvents[3].InVokeAction();
            inputIndex = 3;
        }
    }
}
