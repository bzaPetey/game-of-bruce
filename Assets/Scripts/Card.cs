using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Card", order = 0)]
public class Card : ScriptableObject {
    [SerializeField]private CardSet cardSet;
    [SerializeField]private CardType cardType;
    [SerializeField]private Rarity rarity;
    [SerializeField]private int cost;
    [SerializeField]private Character character;
    [SerializeField]private string cardName;
    [SerializeField]private string flavourText;
    [SerializeField]private Texture iconName;           //the icon
    [SerializeField]private GameObject modelName;       //the 3D model
}


//dont forget the memorable deadites -- i'll swallow your soul


