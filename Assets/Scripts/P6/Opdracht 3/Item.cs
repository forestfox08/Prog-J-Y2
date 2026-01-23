using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item
{
    public string itemName;
    public ItemTypes itemType;
    public ItemStats stats;
    public int sellPrice;
    public bool isEquipped;

    // Constructor
    public Item(string name, ItemTypes type, ItemStats itemStats, int price)
    {
        itemName = name;
        itemType = type;
        stats = itemStats;
        sellPrice = price;
        isEquipped = false;
    }

    // Methode: geef item-beschrijving
    public string Describe()
    {
        return $"{itemName} ({itemType})\n" +
               $"Damage: {stats.damage}, Defense: {stats.armor}, Weight: {stats.weight}\n" +
               $"Sell Price: {sellPrice}";
    }
}