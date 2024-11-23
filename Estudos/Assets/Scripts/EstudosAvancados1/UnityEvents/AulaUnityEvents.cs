using UnityEngine;
using UnityEngine.Events;

public class AulaUnityEvents : MonoBehaviour
{
    public UnityEvent onPlayerDeath;
    public float health;

    private void Start() {
        TakeDamage(10f);
    }

    public void TakeDamage(float damage) {
        health -= damage;

        if (health < 0)
        {
            onPlayerDeath?.Invoke();
        }
    }
}
