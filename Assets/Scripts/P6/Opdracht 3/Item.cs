using UnityEngine;

public class Item 
{
    public string name;
    public ItemTypes category;
    public ItemStats stats;
    public int sellPrice;
    public bool isEquipped; 
}

public Item(string Itemname, ItemTypes category, ItemStats stats, int sellPrice)
{
}