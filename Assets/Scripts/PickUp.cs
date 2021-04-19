using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] uint value;
    [SerializeField] AudioClip pickupSound;
    [SerializeField] float pickupVolume = 1f;

    public void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameSession>().score += value;
        AudioSource.PlayClipAtPoint(pickupSound, transform.position, pickupVolume);
        Destroy(gameObject);
    }
}
