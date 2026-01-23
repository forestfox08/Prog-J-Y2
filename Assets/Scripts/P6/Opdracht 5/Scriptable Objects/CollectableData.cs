using UnityEngine;

[CreateAssetMenu(fileName = "CollectableData", menuName = "Scriptable Objects/CollectableData")]
public class CollectableData : ScriptableObject
{
    public string collectableName;
    public CollectableType type;
    public int value;
    public string message;
}