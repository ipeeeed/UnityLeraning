using UnityEngine;

public class EventManager : MonoBehaviour
{
    private void OnEnable() {
        Enemy.onEnemyDie += ShowGameOver;
        
        // Actions.OnGameOver += ShowGameOver;
        // Actions.OnGameOver();
    }

    private void OnDisable() {
        Enemy.onEnemyDie -= ShowGameOver;

        // Actions.OnGameOver -= ShowGameOver;
    }

    private void ShowGameOver() {
        Debug.Log("Game Over!!!");
    }
}
