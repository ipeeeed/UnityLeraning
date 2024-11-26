using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;

    public void OnHit(IDamageable damageable)
    {
        damageable.ApplyDamage(damage);
    }
}
