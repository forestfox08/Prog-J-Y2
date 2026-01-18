using UnityEngine;

public abstract class InventoryItem : MonoBehaviour
{

    public string Name;
    public int Amount;
    
    public InventoryItem(string name, int amount)
    {
        Name = name;
        Amount = amount;
    }
}

public abstract void Use();
}
