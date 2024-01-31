using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //Trying to get this sound to play, but I need to make it play from the player controller
    //since the object will be destroyed just as the sound starts to play.  Having trouble with this...
    //The game still runs but there is a yellow error.
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
