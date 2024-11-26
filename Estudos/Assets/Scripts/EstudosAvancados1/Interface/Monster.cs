using UnityEngine;

public class Monster : MonoBehaviour, IDamageable
{
    public int currentHealth { get; private set; }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // destroy o monstro...
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bullet>())
        {
            ApplyDamage(10);
            collision.GetComponent<Bullet>().OnHit(this);
        }
    }
}
