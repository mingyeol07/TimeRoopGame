using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    [SerializeField] private CardData currentData;
    [SerializeField] private int handIndex;

    public void DataSet(CardData data)
    {
        currentData = data;
    }
}
