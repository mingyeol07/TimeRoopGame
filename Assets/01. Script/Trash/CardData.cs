using UnityEngine;

[CreateAssetMenu(fileName = "Card Data", menuName = "Scriptable Object/Card Data", order = 0)]
public class CardData : ScriptableObject
{
    [SerializeField]
    private string cardName;
    public string CardName { get { return cardName; } }
    [SerializeField]
    private Sprite cardSprite;
    public Sprite CardSprite { get { return cardSprite; } }
    [SerializeField]
    private ActionEvent action;
    public ActionEvent Action { get { return action; } }
    [SerializeField]
    private string info;
    public string Info { get { return info; } }
}