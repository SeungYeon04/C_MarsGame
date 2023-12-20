using System.Collections;
using UnityEngine;

public class Resource : MonoBehaviour, IGatherable
{
    public GameObject ResourceObject;

    public ResourceData ResourceData;

    public ItemData itemToGive;
    public int quantityPerHit = 1;
    public int capacity;



    public void InitResource()
    {
        quantityPerHit = ResourceData.quantityPerHit;
        capacity = ResourceData.capacity;
    }

    IEnumerator ActivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        ResourceObject.SetActive(true);
        InitResource();
    }

    public void Gather(Vector3 hitPoint, Vector3 hitNormal)
    {
        for (int i = 0; i < quantityPerHit; i++)
        {
            if (capacity <= 0) { break; }
            capacity -= 1;
            Instantiate(itemToGive.dropPrefab, hitPoint + Vector3.up, Quaternion.LookRotation(hitNormal, Vector3.up));
        }

        if (capacity <= 0)
        {
            gameObject.SetActive(false);
            ActivateAfterDelay(10.0f);
        }
    }
}
