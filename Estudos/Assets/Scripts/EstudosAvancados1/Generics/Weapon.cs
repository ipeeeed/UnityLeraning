using UnityEngine;

public class Weapon : Item
{
    [SerializeField] private int damage;

    public Weapon(int dmg) {
        this.damage = dmg;
    }
}
