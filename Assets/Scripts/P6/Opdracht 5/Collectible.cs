using UnityEngine;

public class Collectible : MonoBehaviour
{
    public CollectableData data;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(data.message);
            Debug.Log(data.value);

            CollectiblesManager manager = FindFirstObjectByType<CollectiblesManager>();
            manager.totalCollectibles--;

            Debug.Log("Collectible collected! Remaining: " + manager.totalCollectibles);

            Destroy(gameObject);
        }
    }
}


