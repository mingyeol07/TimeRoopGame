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
    [SerializeField] private List<CardSlot> handSlotList = new List<CardSlot>();
    [SerializeField] private List<CardSlot> playSlotList = new List<CardSlot>();

    [SerializeField] private List<CardData> myCardList;
    private List<CardData> muUsedList = new();
    private List<CardData> myHands = new();

    [SerializeField] private GameObject cardPrefab;

    private RectTransform deckTransform;

    //private void Awake()
    //{
    //    deckTransform = GetComponent<RectTransform>();
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        StartCoroutine(DrawCard(handsTransform.Count));
    //    }
    //}

    //private IEnumerator DrawCard(int drawCount)
    //{
    //    for(int i = 0; i < drawCount; i++)
    //    {
    //        int ranCard = Random.Range(0, myDeckList.Count);
    //        Vector2 endPos = handsTransform[myHands.Count].transform.position;

    //        GameObject card = Instantiate(cardPrefab, transform);
    //        card.GetComponent<Card>().Initialize(myDeckList[ranCard], endPos);

    //        card.transform.DOMoveX(endPos.x, 1f);

    //        myHands.Add(myDeckList[ranCard]);
    //        myDeckList.RemoveAt(ranCard);

    //        yield return new WaitForSeconds(0.05f);
    //    }
    //    yield return null;
    //}

    ///// <summary>
    ///// 스테이지를 클리어하고 카드를 얻었을 때 호출하는 함수
    ///// </summary>
    ///// <param name="data"></param>
    //public void AddCard(CardData data)
    //{
    //    myDeckList.Add(data);
    //}
}
