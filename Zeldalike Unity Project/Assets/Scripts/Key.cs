using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collected a key card!");
        PlayerMovement controller = other.GetComponent<PlayerMovement>();
        controller.key++;
        controller.PlaySound(collectedClip);
        Destroy(gameObject);
    }
}
