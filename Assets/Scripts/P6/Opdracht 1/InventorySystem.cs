using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Inventory Item List :)
    public List<InventoryItem> inventory = new List<InventoryItem>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UseItem(ItemType.Battery);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            UseItem(ItemType.Tomato);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            UseItem(ItemType.Wire);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            AddItem(ItemType.Battery, +1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddItem(ItemType.Tomato, +1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            AddItem(ItemType.Wire, +1);
        }
    }

    void AddItem(ItemType type, int amount)
    {
        InventoryItem item = inventory.FirstOrDefault(i => i.itemType == type);

        if (item != null)
        {
            item.amount += amount;
        }

        Debug.Log("Added " + amount + " " + type + " | Total: " + CountItem(type));
    }

    void UseItem(ItemType type)
    {
        InventoryItem itemToUse = inventory.FirstOrDefault(i => i.itemType == type);

        if (itemToUse != null && itemToUse.amount > 0)
        {
            itemToUse.amount--;

            if (itemToUse.amount <= 0)
            {
                Debug.Log("No " + type + " left!");
            }

            int remaining = CountItem(type);
            Debug.Log("Used " + type + " | Remaining: " + remaining);
        }

    }

    int CountItem(ItemType type)
    {
        InventoryItem item = inventory.FirstOrDefault(i => i.itemType == type);
        return item != null ? item.amount : 0;
    }
}
