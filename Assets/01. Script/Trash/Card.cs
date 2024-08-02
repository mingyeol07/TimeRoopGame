// # Systems
using TMPro;

// # Unity
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image img_icon;
    [SerializeField] private TMP_Text txt_name;
    [SerializeField] private TMP_Text txt_info;

    [SerializeField] private CardData cardData;

    private bool isDrag;
    private Vector2 returnPosition;

    public void Initialize(CardData data, Vector2 returnPos)
    {
        cardData = data;
        returnPosition = returnPos;
    }

    private void Update()
    {
        if (!isDrag)
        {
            transform.position = Vector2.Lerp(transform.position, returnPosition, Time.deltaTime * 10f);
        }
        else
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("CardSlot"))
        {
            CardSlot slot = collision.GetComponent<CardSlot>();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Vector2.Distance((Vector2)transform.position, returnPosition) < 1f)
        {
            isDrag = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDrag = false;
    }
}
