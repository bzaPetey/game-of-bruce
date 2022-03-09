using UnityEngine;

[CreateAssetMenu(fileName = "Ranged Weapon", menuName = "Weapon/Ranged Weapon", order = 1)]
public class RangedWeapon : Weapon  {
    [SerializeField] private int range;
}
