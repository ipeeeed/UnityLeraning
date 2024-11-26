using UnityEngine;

public class Prop : MonoBehaviour, IDamageable
{
    public int currentHealth { get; set; }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            DestroyProp();
        }
    }

    private void DestroyProp()
    {
        // código para destruir...
    }
}
