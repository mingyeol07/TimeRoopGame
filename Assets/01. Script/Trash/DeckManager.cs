// # Systems
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

// # Unity
using UnityEngine;

/// <summary>
/// 내가 가지고 있는 카드들 중에 무작위로 데이터를 가져와서 카드 프리팹에 적용시키고 핸드로 이동시키는 클래스
/// </summary>
public class DeckManager : MonoBehaviour
{
    [SerializeField] private List<Transform> handsTransform = new List<Transform>();

    [SerializeField] private GameObject cardPrefab;

    [SerializeField] private List<CardData> myDeckList;
    private List<CardData> muUsedList;

    private List<GameObject> myHands;

    private RectTransform deckTransform;

    private void Awake()
    {
        deckTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        DrawCard();
    }

    private void DrawCard()
    {
        int ranCard = Random.Range(0, myDeckList.Count);

        GameObject card = Instantiate(cardPrefab, deckTransform.position, Quaternion.identity);
        card.GetComponent<Card>().Initialize(myDeckList[ranCard]);

        muUsedList.Add(myDeckList[ranCard]);
        myDeckList.RemoveAt(ranCard);

        CardMoveToHand(card.transform);
    }

    private void CardMoveToHand(Transform cardTransform)
    {
        float endPosX = handsTransform[myHands.Count].position.x;

        cardTransform.DOMoveX(endPosX, 1f);
    }

    /// <summary>
    /// 스테이지를 클리어하고 카드를 얻었을 때 호출하는 함수
    /// </summary>
    /// <param name="data"></param>
    public void AddCard(CardData data)
    {
        myDeckList.Add(data);
    }
}
