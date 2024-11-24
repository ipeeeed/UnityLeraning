using System;
using UnityEngine;

/// <summary>
/// Func é um delegate que encapsula um método que tem um parâmetro e retorna um valor do tipo especificado pelo perâmetro.
/// 
/// Lambda é uma função sem nome que calcula e retorna um valor único.
/// Pode ser usado por delegates ou árvores de expressão.
/// Operador => ("vai para" ou "recebe").
/// Lado esquerdo representa os parâmetros da entrada (se houver) e a direita o bloco de intruções.
/// Reduz quantidade de trabalho (linhas) necessárias para iterar com os dados.
/// </summary>
public class FuncLambda : MonoBehaviour
{
    // entrada , entrada, saída
    Func<int, int, int> spread = (num1, num2) => num1 * num2;

    // entra int e sai bool
    Func<float, bool> isShooting = x => x <= 0;

    public GameObject bulletPrefab;

    public float fireCooldown = 2f;

    private void Update()
    {
        fireCooldown -= Time.deltaTime;

        if (isShooting(fireCooldown))
        {
            Fire();
            fireCooldown = 2f;
        }
    }

    // void Fire() => Debug.Log("Atirou");
    void Fire()
    {
        Vector2 spreadPos = new Vector2(spread(10, 20), transform.position.y);
        Instantiate(bulletPrefab, spreadPos, Quaternion.identity);
    }
}
