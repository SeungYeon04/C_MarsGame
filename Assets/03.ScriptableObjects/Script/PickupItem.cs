using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupItem : MonoBehaviour
{
    [SerializeField] private bool destroyOnPickup = true;
    [SerializeField] private LayerMask canBePickupBy;
    [SerializeField] private AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (canBePickupBy.value == (canBePickupBy.value | (1 << other.gameObject.layer)))
        {
            OnPickedUp(other.gameObject);
            //if (pickupSound)
                //SoundManager.PlayClip(pickupSound);

            if (destroyOnPickup)
            {
                Destroy(gameObject);
            }
        }
    }

    protected abstract void OnPickedUp(GameObject receiver);
}