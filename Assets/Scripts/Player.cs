using UnityEngine;

public class Player : ScriptableObject {
    [SerializeField]private Avatar avatar;
    [SerializeField]private Card[] collection;
    [SerializeField]public Card[] Deck {get; set;}
    [SerializeField]public Card[] Hand  {get; set;}

    public void Init() {
    }
}
