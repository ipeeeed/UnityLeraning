using UnityEngine;

/// <summary>
/// Events são um tipo especial de Delegates multi-cast. Ambos funcionam da mesma maneira.
/// Diferentemente de Delegates, Events só podem ser acionados ou modificados dentro de sua própria classe.
/// Adiciona uma camada amais de proteção.
/// </summary>
public class Enemy : MonoBehaviour
{
    public delegate void OnEnemyDie();
    public static event OnEnemyDie onEnemyDie;

    private void Start() {
        onEnemyDie?.Invoke();

        // if (onEnemyDie != null)
        // {
        //     onEnemyDie();
        // } else {
        //     Debug.Log("Evento não Encontrado!");
        // }
    }
}
