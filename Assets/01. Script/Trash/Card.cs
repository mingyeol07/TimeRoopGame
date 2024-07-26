// # Systems
using System.Collections;
using System.Collections.Generic;
using TMPro;

// # Unity
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] private Image img_icon;
    [SerializeField] private TMP_Text txt_name;
    [SerializeField] private TMP_Text txt_info;

    public void Initialize(CardData data)
    {
        
    }
}
