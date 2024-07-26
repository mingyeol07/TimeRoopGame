// # Systems
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

// # Unity
using UnityEngine;

/// <summary>
/// ���� ������ �ִ� ī��� �߿� �������� �����͸� �����ͼ� ī�� �����տ� �����Ű�� �ڵ�� �̵���Ű�� Ŭ����
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
    /// ���������� Ŭ�����ϰ� ī�带 ����� �� ȣ���ϴ� �Լ�
    /// </summary>
    /// <param name="data"></param>
    public void AddCard(CardData data)
    {
        myDeckList.Add(data);
    }
}
