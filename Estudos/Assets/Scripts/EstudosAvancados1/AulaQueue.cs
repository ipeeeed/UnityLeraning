using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Queue é uma coleção de objetos, semelhante a um Array ou List.
/// A diferença é que voçê só consegue "manipular" o primenrio e o último elemento.
/// Enqueue => Add objeto ao final.
/// Dequeue => Remove e retorna o objeto no início.
/// Peek => Retorna o objeto ao início sem remove-lo.
/// </summary>
public class AulaQueue : MonoBehaviour
{
    // Queue myQueue = new Queue();
    Queue<int> myQueue = new Queue<int>();

    public int[] myQueueArray;

    private void Start()
    {
        myQueue.Enqueue(5);
        myQueue.Enqueue(7);
        myQueue.Enqueue(23);

        // myQueueArray = myQueue.ToArray();

        int V = myQueue.Dequeue();
        V = myQueue.Dequeue();

        myQueue.Enqueue(100);

        V = myQueue.Dequeue();
        V = myQueue.Dequeue();
    }
}
