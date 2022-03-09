//buff vs dmg vs debuff
//target character or placement on ground or target self
using UnityEngine;

[CreateAssetMenu(fileName = "Cards/Spell", menuName = "Spell", order = 1)]
public class Spell : Card  {
    [SerializeField]private Effect effect;
}
