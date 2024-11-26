using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Usado para empilhamento
/// Push => add um objeto a pilha
/// Pop => remove e retorna o primeiro objeto da pilha
/// Peek => retorna o primeiro objeto sem remove-lo
/// </summary>
public class AulaStack : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;


    public Stack<GameObject> players = new Stack<GameObject>();

    private void Start()
    {
        players.Push(player1);
        players.Push(player2);
        players.Push(player3);

        ShowStack(players);

        // players.Pop();
    }

    void ShowStack(Stack<GameObject> s)
    {
        foreach (var item in s)
        {
            Debug.Log(item.name);
        }
    }
}
