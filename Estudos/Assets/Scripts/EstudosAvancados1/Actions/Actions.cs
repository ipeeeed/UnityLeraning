using System;
using UnityEngine;

/// <summary>
/// Action é um delegate pronto.
/// Usado para criar um delegate com retorno void.
/// </summary>
public class Actions : MonoBehaviour
{
    // isso aqui...
    public static event Action<string, int> OnGameOver;

    // ... é a mesma coisa que isso aqui.
    // public delegate void OnGameOver(string s, int i);
    // public static event OnGameOver onGameOver;

    float health;
    public void Damage(float damage) {
        health -= damage;
        if (health <= 0)
        {
            OnGameOver?.Invoke("Algum texto", 10);
        }
    }
}
