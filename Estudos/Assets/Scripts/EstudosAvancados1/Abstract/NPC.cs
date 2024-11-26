using UnityEngine;

/// <summary>
/// Classe abstrata sempre é uma superclasse
/// Força a implementação de seus métodos na classe herdada
/// Geralmente possui métodos abstratos
/// </summary>
public abstract class NPC : MonoBehaviour
{
    protected string NPCName;
    protected float speed;
    protected bool isWalking;

    public abstract void Walk();
    public abstract void Speech();
}
