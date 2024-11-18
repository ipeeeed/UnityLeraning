using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class ItemObject : ScriptableObject
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private string itemName = "New Item";
    [SerializeField] private int price = 20;
    [SerializeField] private Sprite icon = null;
    
    public string ItemName { get => itemName; private set => itemName = value; }
    public Sprite Icon { get => icon; private set => icon = value; }
    public int Price { get => price; private set => price = value; }
}
