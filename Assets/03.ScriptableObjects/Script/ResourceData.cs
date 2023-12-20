using UnityEngine;

[CreateAssetMenu(fileName = "Resource_", menuName = "New Resource")]
public class ResourceData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public ItemData itemToGive;

    [Header("amount")]
    public int quantityPerHit = 1;
    public int capacity;
}
