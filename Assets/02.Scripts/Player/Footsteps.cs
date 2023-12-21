using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepClips;
    private AudioSource audioSource;
    private Rigidbody _rigidbody;
    public float footstepThreshold;
    public float footstepRate;
    private float lasgFootstepTime;

    //private bool isGrounded;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {

        if (Mathf.Abs(_rigidbody.velocity.y) < 0.1f )
        {
            if (_rigidbody.velocity.magnitude > footstepThreshold)
            {
                if (Time.time - lasgFootstepTime > footstepRate)
                {
                    lasgFootstepTime = Time.time;
                    audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]);
                }
            }
        }
    }
    //private bool IsGrounded()
    //{

    //    PlayerController playerController = GetComponent<PlayerController>();

    //    if (playerController != null)
    //    {
    //        return playerController.isGrounded;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}