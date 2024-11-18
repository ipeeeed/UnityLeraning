using System.Collections.Generic;
using UnityEngine;

public class GenericTest : MonoBehaviour
{
    [SerializeField] private List<Item> itens = new List<Item>();

    private void Start() {
        itens.Add(new Item());
        itens.Add(new Item());
        itens.Add(new Item());

        foreach (var item in GetItemByType<Item>())
        {
            Debug.Log(item);
        }
    }

    List<Item> GetItemByType<T>() where T : Item {
        List<Item> itensReturn = new List<Item>();
        for (int i = 0; i < itens.Count; i++)
        {
            if (itens[i] is T)
            {
                itensReturn.Add(itens[i]);
            }
        }
        return itensReturn;
    }
}
