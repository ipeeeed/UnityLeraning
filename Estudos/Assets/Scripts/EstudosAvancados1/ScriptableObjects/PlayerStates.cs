using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Inventory/Player Stats")]
public class PlayerStates : ScriptableObject
{
    [SerializeField] private int goldAmount;
    [SerializeField] private float health;

    [SerializeField] private ItemObject currentUsedItem;
    
    [SerializeField] private List<ItemObject> inventory = new List<ItemObject>();
}
