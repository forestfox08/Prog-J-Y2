using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public 

    void Update()
    {
        if input.GetKeyDown(KeyCode.1)
        {
            Debug.Log("1 pressed!!!!");
            UseItem("Battery");
        }
        if input.GetKeyDown(KeyCode.2)
        {
            Debug.Log("2 pressed!!!!");
            UseItem("Tomato");
        }
        if input.GetKeyDown(KeyCode.3)
        {
            Debug.Log("3 pressed!!!!");
            UseItem("Wire");
        }
    }
    void UseItem(string itemName)
    {
        Debug.Log("Using item: " + itemName);
    }
}
