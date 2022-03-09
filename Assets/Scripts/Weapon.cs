using UnityEngine;

[CreateAssetMenu(fileName = "Melee Weapon", menuName = "Weapon/Melee Weapon", order = 2)]
public class Weapon : Item {
    [SerializeField]private int damage;
    [SerializeField]private float variance;
}


//Boomstick - "Swallow This.." clip plays on use
//Ripper - only eqiupable on characters missing a hand. --- Does this lead to the ability to disfigure your avatar?
//pistol from Brisco Country jr
