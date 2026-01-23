using UnityEngine;

[CreateAssetMenu(fileName = "ItemTemplate", menuName = "Scriptable Objects/ItemTemplate")]
public class ItemTemplate : ScriptableObject
{
    public string itemName;
    public int sellPrice;
    public ItemTypes category;
    public ItemStats stats;
    public Sprite icon;


    public Item CreateInstance()
    {
        return new Item(itemName, category, stats, sellPrice);
    }

    public void LogTemplate()
    {
        Debug.Log($"Template: {itemName} (Price: {sellPrice})");
    }
}