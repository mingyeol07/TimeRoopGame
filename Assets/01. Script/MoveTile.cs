// # Systems
using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

public class MoveTile : MonoBehaviour
{
    private bool isDrag;
    private Vector2 returnPosition;

    private void Start()
    {
        returnPosition = transform.position;
    }

    private void Update()
    {
        if(!isDrag)
        {
            transform.position = Vector2.Lerp(transform.position, returnPosition, Time.deltaTime * 5f);
        }
    }

    private void OnMouseDown()
    {
        if (Vector2.Distance((Vector2)transform.position, returnPosition) < 1f ) {
            isDrag = true;
        }
     }

    private void OnMouseDrag()
    {
        if (isDrag)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
    }

    private void OnMouseUp()
    {
        Vector2 nearPosition = TileSpaceManager.instance.GetNearTileSpace(transform.position);
        if(Vector2.Distance(nearPosition, transform.position) < 0.5f) 
        {
            returnPosition = nearPosition;
        }
        isDrag = false;
    }
}
