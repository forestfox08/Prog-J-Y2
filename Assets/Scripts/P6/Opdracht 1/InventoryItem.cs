using UnityEngine;

public enum ItemType
{
    Battery,
    Wire,
    Tomato
}

[CreateAssetMenu(fileName = "ItemInfo", menuName = "Item Information", order = 0)]
public class InventoryItem: ScriptableObject
{
    public int amount;
    public ItemType itemType;
    private ItemType type;

    public InventoryItem(ItemType type)
    {
        this.type = type;
    }
}